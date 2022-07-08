using Business;
using Common;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using Entity;
using Microsoft.Win32;
using Security;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Importar
{
    public partial class FormPrincipal : DevExpress.XtraEditors.XtraForm
    {
        #region[Objetos/Variaveis]
        string versaoDessePrograma = Application.ProductVersion;
        AppConfigString config = new AppConfigString();
        BusinessProdutos objProd = new BusinessProdutos();
        private SqlConnection _con;
        private SqlCommand _command;
        const string nomeCaminho = "caminhoArquivo";
        DTICrypto objCrypto = new DTICrypto();
        string caminhoArquiv;
        int linha;
        public TTABTERM lista_terminais = new TTABTERM();
        public TCCONFIG receberConfiguracao = new TCCONFIG();
        public int idTerminalSelecionado;
        public int tempoAcumulado = 0;
        public long acumulo = 0;
        string moeda = "R$";
        public static System.Timers.Timer _timer4;
        #endregion
        #region[Atualizar o Grid Produtos]
        public void AtualizaGrid(bool showAll)
        {
            this.gdcBuscaPreco.DataSource = objProd.obterLista(showAll, this.linkLabel1);
        }
        #endregion
        #region[Captura o caminho do arquivo]
        private static string GetDestFileName()
        {
            string destFileName = ConfigurationManager.AppSettings["caminhoArquivo"];
            return destFileName;
        }
        #endregion
        #region[Carrega o Caminho do Arquivo]
        public void carregaCaminhoArquivo()
        {
            caminhoArquiv = GetDestFileName();
            if (caminhoArquiv == string.Empty || caminhoArquiv == null)
            {
                btnLocalizar.Visible = true;
                btnExportar.Visible = false;
            }
            else
            {
                txtLocalizar.Text = caminhoArquiv;
                btnLocalizar.Visible = false;
                btnExportar.Visible = true;
            }
        }
        #endregion
        #region[Exportar Lista de Produtos]
        public void EscreverArquivo()
        {
            if (txtLocalizar.Text.Trim() != string.Empty)
            {

                string arquivo = txtLocalizar.Text;
                if (File.Exists(arquivo))
                {
                    try
                    {
                        CsvExportOptions options = new CsvExportOptions();
                        options.Separator = "|";
                        gdvBuscaPreco.ExportToCsv(arquivo, options);
                        var file = new List<string>(File.ReadAllLines(arquivo));
                        file.RemoveAt(0);
                        File.WriteAllLines(arquivo, file.ToArray());
                        XtraMessageBox.Show(string.Format(Mensagens.ARQUIVO_EXPORTADO_COM_SUCESSO, arquivo), "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    XtraMessageBox.Show(string.Format(Mensagens.ARQUIVO_NAO_LOCALIZADO, arquivo), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion
        #region[Inicia com o Windows]
        public static void startup(bool OnOff)
        {
            try
            {
                string appName = "Busca Preço Gertec - Eccus Informática";
                string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
                RegistryKey startupKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (OnOff)
                {
                    if (startupKey.GetValue(appName) == null)
                    {
                        startupKey.SetValue(appName, @"""" + Application.ExecutablePath.ToString() + @"""");
                        startupKey.Close();
                    }
                }
                else
                {
                    startupKey = Registry.LocalMachine.OpenSubKey(runKey, true);
                    startupKey.DeleteValue(appName, false);
                    startupKey.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region[Construtor]
        public FormPrincipal()
        {
            InitializeComponent();
            lblStatusVersao.Text = versaoDessePrograma;
            _timer4 = new System.Timers.Timer();
            _timer4.AutoReset = true;
            _timer4.Elapsed += new System.Timers.ElapsedEventHandler(executarTarefa);
            _timer4.Enabled = true;
        }
        #endregion
        #region[Inicialização do Busca Preço]
        public void Inicialize()
        {
            sc501ger.vInitialize();
            sc501ger.tc_startserver();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            AtualizaGrid(true);
            carregaCaminhoArquivo();
            chkIniciaWindows.Checked = Properties.Settings.Default.iniciaWindows;
            chkModoExportImport.Checked = Properties.Settings.Default.ativaModo;
        }
        #endregion
        #region[Log]
        public void popularLog(string tipo, string mensagem)
        /*Método que quando é chamado (Recebendo duas Strings), preenche a lista lbLog e seleciona o item que foi preenchido*/
        {
            lbLog.Items.Add(System.DateTime.Now + " - " + tipo + ": " + mensagem);
            lbLog.SelectedIndex = Convert.ToInt32(lbLog.Items.Count - 1);
        }
        #endregion
        #region[Valida Terminal Conectado e selecionado]
        public bool validarConectadoSelecionado()
        {
            bool retorno = false;
            try
            {
                TTABTERM lista_terminais = new TTABTERM(); // Instancia uma 'struct' do tipo TTABTERM
                sc501ger.GetTermConectados(1, ref lista_terminais); //Obtem a lista de terminais conectados

                //-- Validações de Terminal conectado e/ou selecionado --//
                if (lista_terminais.NumSockConec < 1)
                {
                    popularLog("ERRO", "Não há nenhum Terminal conectado ou Não está selecionado.");
                }
                else
                {
                    if (lista_terminais_conectados.SelectedIndex < 0)
                    {
                        popularLog("ERRO", "Não há Nenhum Terminal selecionado.");
                    }
                    else
                    {
                        retorno = true;
                        popularLog("PROCESSO", "Conexão realizado com sucesso!!!");
                    }
                }
            }
            catch (Exception erro)
            {
                popularLog("ERRO", "Erro ao Enviar Comando!" + erro);
            }
            return retorno;
        }
        #endregion
        #region[Executar Tarefa para atualizar o preço]
        public void executarTarefa(object sender, System.Timers.ElapsedEventArgs e)
        {
            _timer4.Enabled = false;
            AtualizaGrid(true);
            _timer4.Enabled = true;
        }
        #endregion


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Inicialize();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            acumulo++;


            byte[] bufRecebeu = new byte[30];
            int[] idTerminalEnviou = new int[5];
            int[] portaSerial = new int[5];
            int[] nrBarramento = new int[5];


            if (sc501ger.bReceiveBarcode(idTerminalEnviou, portaSerial, bufRecebeu, nrBarramento))
            {
                /*Tratar código de barras recebido*/

                int qtdProdListados = (gdvBuscaPreco.RowCount - 1);
                string codBarras = "";
                int correrNoBuffer = 1;
                int correrAuxiliar = correrNoBuffer - 1;

                codBarras = Encoding.ASCII.GetString(bufRecebeu);
                codBarras = codBarras.Replace("#", "");
                codBarras = codBarras.Replace("\0", "");
                popularLog("Código de Barra Lido", codBarras);

                //percorrer a lista de produtos para "PROCURAR" o código recebido

                string valorCelula = "";
                string nomeProdutoTabela = "";
                string valorProdutoTabela = "";
                for (int contador = 0; contador < qtdProdListados; contador++)//Percorrer a lista de produtos para verificar se o item pesquisado está cadastrado
                {
                    valorCelula = Convert.ToString(gdvBuscaPreco.GetRowCellValue(contador, gdcCodBarra));
                    if (valorCelula.Equals(codBarras))
                    {
                        nomeProdutoTabela = Convert.ToString(gdvBuscaPreco.GetRowCellValue(contador, gdcDescricao));
                        valorProdutoTabela = Convert.ToString(moeda + gdvBuscaPreco.GetRowCellValue(contador, gdcVenda));

                        byte[] nomeProduto = new byte[5];
                        byte[] precoProduto = new byte[5];

                        //mandar o produto e o preço para o terminal que enviou o código de barras ou retornar mensagem de produto não cadastrado

                        if (nomeProdutoTabela != "")
                        {
                            nomeProduto = Encoding.Default.GetBytes(nomeProdutoTabela);
                            precoProduto = Encoding.Default.GetBytes(valorProdutoTabela);
                            sc501ger.bSendProdPrice(idTerminalEnviou[0], nomeProduto, precoProduto);
                            popularLog("Produto localizado", nomeProdutoTabela + " " + valorProdutoTabela);
                        }
                        else //Se o item não for encontrado, chamar a função da DLL bSendProdNotFound, que retorna no display "Produto não cadastrado"
                        {
                            sc501ger.bSendProdNotFound(idTerminalEnviou[0]);
                            popularLog("Produto localizado", "Produto não encontrado");
                        }

                    }
                }
            }
        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog() { Title = Mensagens.SELECIONAR_ARQUIVO, InitialDirectory = @"c:\", FileName = txtLocalizar.Text, Filter = Mensagens.FILTRO, FilterIndex = 1, RestoreDirectory = true };
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtLocalizar.Text = fdlg.FileName;
                config.configurarCaminhoArquivo(nomeCaminho, txtLocalizar.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                TTABTERM lista_terminais = new TTABTERM();
                sc501ger.GetTermConectados(1, ref lista_terminais);                          //Obtém a lista de terminais conectados
                int quantidadeTerminaisListados = lista_terminais_conectados.Items.Count;   //armazenar quantos terminais estão na lista
                int quantidadeTerminaisConectados = lista_terminais.NumSockConec;           //armazenar quantos terminais estão conectados 

                int controle = 0;
                if (lista_terminais.NumSockConec > 0)                                       //Carrega os terminais conectados em uma lista sequencialmente
                {
                    while (controle != lista_terminais.NumSockConec)                        //controla se todos os terminais foram conectados
                    {
                        byte[] ip_convertido = new byte[20];
                        string ip = "";
                        sc501ger.TCinet_ntoa(lista_terminais.TabIP[controle], ip_convertido);   //Recebe da DLL o IP do terminal formatado com pontos "pontos"
                        ip = ((System.Text.Encoding.UTF8.GetString(ip_convertido)).Replace("\0", "")).Trim(); //Remove os "Zeros" ao fim do IP
                        if (!lista_terminais_conectados.Items.Contains(ip))                                    //Verifica se o IP já está na lista 
                        {
                            lista_terminais_conectados.Items.Add(ip);                                           //Caso não esteja adiciona na lista
                            quantidadeTerminaisListados++;                                                      //Conta o terminal adicionado        

                        }
                        controle++;
                    }
                }
                // Limpar lista dos terminais que foram desconectados
                if (quantidadeTerminaisListados > quantidadeTerminaisConectados) //verifica se existem terminais listados que foram desconectado
                {
                    //Limpa todos os itens da lista, os itens que ainda estão conectados serão conectados novamente na próxima volta do TIMER
                    for (int contador = 1; contador <= quantidadeTerminaisListados; contador++)
                    {
                        lista_terminais_conectados.Items.RemoveAt(contador - 1);
                    }
                }


            }
            catch
            {
                popularLog("ERRO", "Ocorreu um erro durante a operação");
            }
        }

        private void gdvBuscaPreco_RowCountChanged(object sender, EventArgs e)
        {
            linha = Convert.ToInt32(this.gdvBuscaPreco.RowCount.ToString());
            lblContador.Visible = true;
            lblItensExibicao.Visible = true;
            this.lblContador.Text = linha.ToString().PadLeft(9, '0');
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            EscreverArquivo();
        }

        private void btnRecebDoTerm_Click(object sender, EventArgs e)
        {
            try
            {
                sc501ger.GetTermConectados(1, ref lista_terminais);

                if (validarConectadoSelecionado())
                {
                    //Pede configurações do terminal selecionado
                    idTerminalSelecionado = lista_terminais.TabSock[lista_terminais_conectados.SelectedIndex];//Obter o ID (NUM Socket) do terminal selecionado
                    if (sc501ger.bPedeConfig(idTerminalSelecionado)) //Chamar função bPedeConfig para a DLL
                    {
                        popularLog("PROCESSO", "Configurações solicitadas com sucesso"); //Mandar para a log que a função bPedeConfig foi solicitada com sucesso
                        Thread.Sleep(100);
                        sc501ger.bReceiveConfig(ref receberConfiguracao); //Chamar função bReceiveConfig para a DLL, para pegar as informações previamente solicitadas
                        popularLog("PROCESSO", "Configurações recebidas com sucesso");

                        //Preenche as caixas de texto com as informações recebidas

                        txtIdTerm.Text = Convert.ToString(idTerminalSelecionado);
                        txtIPServidor.Text = ASCIIEncoding.Default.GetString(receberConfiguracao.host);
                        txtIpTerminal.Text = ASCIIEncoding.Default.GetString(receberConfiguracao.endereco);
                        txtMascRede.Text = ASCIIEncoding.Default.GetString(receberConfiguracao.msknet);
                        txtMsg1.ForeColor = Color.Black;
                        txtMsg1.Text = ASCIIEncoding.Default.GetString(receberConfiguracao.texto1);
                        txtMsg2.ForeColor = Color.Black;
                        txtMsg2.Text = ASCIIEncoding.Default.GetString(receberConfiguracao.texto2);
                        txtMsg3.ForeColor = Color.Black;
                        txtMsg3.Text = ASCIIEncoding.Default.GetString(receberConfiguracao.texto3);
                        txtMsg4.ForeColor = Color.Black;
                        txtMsg4.Text = ASCIIEncoding.Default.GetString(receberConfiguracao.texto4);
                        txtTexib.Text = Convert.ToString(receberConfiguracao.tempoExib);
                    }
                }
            }
            catch (Exception erro)
            {
                popularLog("ERRO", "Configurações solicitadas com erro" + erro);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            sc501ger.GetTermConectados(1, ref lista_terminais);
            if (validarConectadoSelecionado())
            {
                try
                {
                    //------------------MANDAR CONFIGURAÇÕES PARA TERMINAL------------------//

                    /*
                         As informações são mandadas para  a DLL utilizando a função "bMandaConfig" 
                         - Primeiramente os dados são carregados em uma estrutura definida do tipo TCCONFIG, no caso abaixo chamada de "mandaConfig"
                         depois enviamos uma referencia da estrutura preenchida "sc501ger.bMandaConfig(ref mandaConfig)"
                     */
                    TCCONFIG mandaConfig = new TCCONFIG();      //Declaração da estrutura do tipo "TCCONFIG"
                    byte[] hostConteudo, enderecoConteudo, msknetConteudo, texto1Conteudo, texto2Conteudo, texto3Conteudo, texto4Conteudo;
                    byte[] host, endereco, msknet, texto1, texto2, texto3, texto4 = new byte[22];


                    /*Os vetores de bytes são inicializados com os valores '00' para ocupação de espaço*/
                    host = ASCIIEncoding.Default.GetBytes("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0");
                    endereco = ASCIIEncoding.Default.GetBytes("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0");
                    msknet = ASCIIEncoding.Default.GetBytes("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0");
                    texto1 = ASCIIEncoding.Default.GetBytes("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0");
                    texto2 = ASCIIEncoding.Default.GetBytes("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0");
                    texto3 = ASCIIEncoding.Default.GetBytes("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0");
                    texto4 = ASCIIEncoding.Default.GetBytes("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0");

                    /*Os vetores de byte estão recebendo as informações preenchidas nos campos de usuário*/
                    hostConteudo = ASCIIEncoding.Default.GetBytes(txtIPServidor.Text);
                    enderecoConteudo = Encoding.Default.GetBytes(txtIpTerminal.Text);
                    msknetConteudo = Encoding.Default.GetBytes(txtMascRede.Text);
                    texto1Conteudo = ASCIIEncoding.Default.GetBytes(txtMsg1.Text);
                    texto2Conteudo = ASCIIEncoding.Default.GetBytes(txtMsg2.Text);
                    texto2Conteudo = Encoding.Default.GetBytes(txtMsg2.Text);
                    texto3Conteudo = Encoding.Default.GetBytes(txtMsg3.Text);
                    texto4Conteudo = Encoding.Default.GetBytes(txtMsg4.Text);
                    idTerminalSelecionado = lista_terminais.TabSock[lista_terminais_conectados.SelectedIndex];
                    mandaConfig.ID = idTerminalSelecionado;

                    /* O método é chamado passando:
                     * uma referencia de um vetor de bytes não formatado, mas com as informações corretas, Exemplo:'byte[] hostConteudo',
                     * uma referencia de um outro vetor de bytes que receberá o conteudo formatado pelo 'método PreencherByte', Exemplo:'byte[] host';*/
                    preencherByte(ref hostConteudo, ref host, 22);
                    preencherByte(ref enderecoConteudo, ref endereco, 22);
                    preencherByte(ref msknetConteudo, ref msknet, 22);
                    preencherByte(ref texto1Conteudo, ref texto1, 22);
                    preencherByte(ref texto2Conteudo, ref texto2, 22);
                    preencherByte(ref texto3Conteudo, ref texto3, 22);
                    preencherByte(ref texto4Conteudo, ref texto4, 22);

                    /*Cada campo da estrutura do tipo TCCONFIG é preenchido com o conteúdo dos vetores de byte formatados*/
                    mandaConfig.host = host;            //- IP servidor formatado por pontos;
                    mandaConfig.endereco = endereco;    //- IP terminal formatado por pontos;
                    mandaConfig.msknet = msknet;        //- msknet: mascara de rede formatado por pontos;
                    mandaConfig.texto1 = texto1;        //- texto1/2/3/4: texto das linhas 1/2/3/4;
                    mandaConfig.texto2 = texto2;
                    mandaConfig.texto3 = texto3;
                    mandaConfig.texto4 = texto4;
                    mandaConfig.tempoExib = Convert.ToByte(txtTexib.Text);      //tempo de exibição dos pares de linhas, convertido para byte
                    sc501ger.bMandaConfig(ref mandaConfig);                     //chamada da função da DLL 'bMandaConfig', passando um ref de uma estrutura TCCONFIG 
                    popularLog("Processo", "Configuração enviada com sucesso"); //manda para log confirmação do processo
                }
                catch (Exception erro)
                {
                    //manda log em caso de erro, manda a descrição do erro lançado
                    popularLog("Erro", Convert.ToString(erro));
                }
            }
        }

        public void preencherByte(ref byte[] recepcao, ref byte[] devolucao, int tamanho)
        {
            /* ----- Este método receberá duas referencias de 'byte[]' (recepção e devolução) e um número tamanho que devolução deverá conter -----*/

            int tamanhoByteRecepcao = recepcao.Length;
            if (tamanhoByteRecepcao == tamanho)
            {
                //verifica se o byte[] recebido já está no tamanho correto
            }
            else
            {
                for (int contador = 0; contador < tamanhoByteRecepcao; contador++)
                {
                    devolucao[contador] = recepcao[contador];
                }
            }
        }

        private void txtEnviarMsgRap_Click(object sender, EventArgs e)
        {
            try
            {
                sc501ger.GetTermConectados(1, ref lista_terminais);
                if (validarConectadoSelecionado()) //Se a função retornar TRUE, significa que existe um terminal conectado e existe um terminal selecionado 
                {
                    // -- Variáveis -- // 
                    int id, tempoDeExibicao;
                    byte[] line1, line2 = new byte[100];

                    // -- Preencher variáveis que serão usadas para mandar informação para a DLL -- //
                    line1 = System.Text.Encoding.ASCII.GetBytes(txtLine1.Text);
                    line2 = System.Text.Encoding.ASCII.GetBytes(txtLine2.Text);
                    id = lista_terminais.TabSock[lista_terminais_conectados.SelectedIndex];
                    tempoDeExibicao = Convert.ToInt32(txtTimeExib.Text);
                    if (tempoDeExibicao < 0) //-- Define um valor mínimo para o tempo de exibição --//
                    {
                        tempoDeExibicao = 0;
                    }
                    if (tempoDeExibicao >= 256) //-- Define um valor máximo para o tempo de exibição --//
                    {
                        tempoDeExibicao = 255;
                    }
                    sc501ger.bSendDisplayMsg(id, line1, line2, tempoDeExibicao, 48);                                      /*Manda os valores carregados para a DLL*/
                    popularLog("Processo", "Mensagem Enviada Com Sucesso! Verifique O Display Terminal Selecionado" + id);       /*Preenche a Log*/
                }
            }
            catch (Exception erro)
            {
                popularLog("Erro", "Erro Ao Enviar Comando!" + erro);
            }
        }

        private void btnLocalizar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLocalizar.Text))
            {
                btnLocalizar.Visible = false;
                btnExportar.Visible = true;
            }
            else
            {
                btnLocalizar.Visible = true;
                btnExportar.Visible = false;
            }
        }

        private void gdvBuscaPreco_RowCountChanged_1(object sender, EventArgs e)
        {
            linha = Convert.ToInt32(this.gdvBuscaPreco.RowCount.ToString());
            lblContador.Visible = true;
            lblItensExibicao.Visible = true;
            this.lblContador.Text = linha.ToString().PadLeft(9, '0');
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarConectadoSelecionado())
                {
                    sc501ger.GetTermConectados(1, ref lista_terminais); //Obtem a lista de terminais conectados
                    idTerminalSelecionado = lista_terminais.TabSock[lista_terminais_conectados.SelectedIndex];  //Obter ID do terminal selecionado
                    sc501ger.bSendRestartSoft(idTerminalSelecionado);
                }
            }
            catch (Exception erro)
            {
                popularLog("ERRO! ", Convert.ToString(erro.Message));
            }
        }

        private void chkIniciaWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIniciaWindows.Checked)
            {
                Properties.Settings.Default.iniciaWindows = true;

            }
            else
            {
                Properties.Settings.Default.iniciaWindows = false;
                chkIniciaWindows.CheckState = CheckState.Unchecked;
            }
            startup(chkIniciaWindows.Checked);
            Properties.Settings.Default.Save();
        }

        private void FormPrincipal_SizeChanged(object sender, EventArgs e)
        {
            string appName = "Busca Preço Gertec - Eccus Informática";
            RegistryKey startupKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (startupKey.GetValue(appName) == null)
            {
                ntfBuscaPreco.Visible = false;
                Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    ntfBuscaPreco.Visible = true;
                    timer3.Enabled = true;
                    Hide();
                    ntfBuscaPreco.ShowBalloonTip(1000, "Busca Preço Gertec - Eccus Informática", "Inicializado", ToolTipIcon.Info);
                }
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            string appName = "Busca Preço Gertec - Eccus Informática";
            RegistryKey startupKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (startupKey.GetValue(appName) == null)
            {
                ntfBuscaPreco.Dispose();
                Application.Exit();
                Process[] progress = Process.GetProcessesByName("Importar");
                foreach (Process prog in progress)
                {
                    prog.Kill();
                }
            }
            else
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                ntfBuscaPreco.Visible = true;
                timer3.Enabled = true;
                Hide();
            }
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void conClose_Click(object sender, EventArgs e)
        {
            ntfBuscaPreco.Dispose();
            Application.Exit();
            Process[] progress = Process.GetProcessesByName("Importar");
            foreach (Process prog in progress)
            {
                prog.Kill();
            }
        }

        private void ntfBuscaPreco_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void chkModoExportImport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModoExportImport.Checked)
            {
                Properties.Settings.Default.ativaModo = true;
                pnlLocalizaArquivo.Visible = true;
                btnExportar.Visible = true;

            }
            else
            {
                Properties.Settings.Default.ativaModo = false;
                chkModoExportImport.CheckState = CheckState.Unchecked;
                pnlLocalizaArquivo.Visible = false;
                btnExportar.Visible = false;
            }
            Properties.Settings.Default.Save();
        }
    }
}