using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Common;
using Entity;
using Dao;
using System.Data.OleDb;
using System.IO;

namespace Importar
{
    public partial class FormImportar : DevExpress.XtraEditors.XtraForm
    {
        Produto prod = new Produto();
        public FormImportar()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
        }

        public static string SelecionarTabela = string.Empty;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (txtPesqProdutos.Text.Trim() != string.Empty)
            {

                string arquivo = txtPesqProdutos.Text;
                    if (File.Exists(arquivo))
                    {
                        try
                        {
                             StreamReader sr = new StreamReader(arquivo);
                             OleDbConnection conn = new OleDbConnection(Conexao.stringDeConexao);

                            conn.Open();
                            int contador = 0;
                            string linha;

                            while ((linha = sr.ReadLine()) != null)
                            {

                                string[] partes = linha.Split(new string[] { "|" }, StringSplitOptions.None);
                                string linhas = string.Format("{0,13} {1,4} {2,10} ", partes[0], partes[1], partes[2]);
                                // mmImportar.Text += linha;
                                string sql = string.Format(Mensagens.INSERIR_LINHAS, partes[0], partes[1], partes[2]);
                                contador++;
                                using (OleDbCommand command = new OleDbCommand(sql, conn))
                                {
                                   // command.ExecuteNonQuery();
                                }
                            }
                            sr.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show(string.Format(Mensagens.ARQUIVO_NAO_LOCALIZADO, arquivo), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog() { Title = Mensagens.SELECIONAR_ARQUIVO, InitialDirectory = @"c:\", FileName = txtPesqProdutos.Text, Filter = Mensagens.FILTRO, FilterIndex = 1, RestoreDirectory = true };
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    txtPesqProdutos.Text = fdlg.FileName;

                    if (!backgroundWorker1.IsBusy)
                    {
                        Dictionary<string, object> consulta = new Dictionary<string, object>();
                        consulta.Add("obj", new Produto());
                        backgroundWorker1.RunWorkerAsync(consulta);
                        btnAbrir.Enabled = false;
                        btnCancelar.Enabled = true;
                    }
                }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //lblStatus.Text = string.Format(Mensagens.CANCELADO_POR_USUARIO);
                //lblStatus.ForeColor = System.Drawing.Color.Red;
                pgsbImport.Value = 0;
            }
            // Verifica se ocorreu algum  erro no processo em background
            else
            {
                if (e.Error != null)
                {
                    // lblStatus.Text = e.Error.Message;
                }
                // DataTable dt = GetDataTableExcel(textBoxLocalizar.Text, SelecionarTabela);
                //  lblStatus.Text = string.Format(Mensagens.REGISTROS_CARREGADOS);
                //  lblStatus.ForeColor = System.Drawing.Color.Blue;
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgsbImport.Value = e.ProgressPercentage;
        }

        private void EscreveArquivo()
        {
            //Declaração do método StreamWriter passando o caminho e nome do arquivo que deve ser salvo
            StreamWriter writer = new StreamWriter(txtPesqProdutos.Text);
            string linha;
            //Escrevendo o Arquivo e pulando uma linha
           // writer.WriteLine("Hello World");
            //Escrevendo o Arquivo sem pular linha
            
                //string[] partes = linha.Split(new string[] { "|" }, StringSplitOptions.None);
                string linhas = string.Format("{0,13}|","{1,4}|","{2,10}", StringSplitOptions.None);
            
            writer.Write(linhas);
            writer.WriteLine();
           // writer.WriteLine("www.devbrasil.net");
            //Fechando o arquivo
            writer.Close();
            //Limpando a referencia dele da memória
            writer.Dispose();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            EscreveArquivo();
        }
    }
}