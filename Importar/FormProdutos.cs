using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Business;
using System.IO;
using System.Data.SqlClient;
using Dao;
using Common;
using Security;
using DevExpress.XtraPrinting;
using System.Configuration;

namespace Importar
{
    public partial class FormProdutos : DevExpress.XtraEditors.XtraForm
    {
        #region[Objetos/Variaveis]
        AppConfigString config = new AppConfigString();
        BusinessProdutos objProd = new BusinessProdutos();
        private SqlConnection _con;
        private SqlCommand _command;
        const string nomeCaminho = "caminhoArquivo";
        DTICrypto objCrypto = new DTICrypto();
        string caminhoArquiv;
        int linha;
        #endregion
        #region[Construtor]
        public FormProdutos()
        {
            InitializeComponent();
        }
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
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            AtualizaGrid(true);
            carregaCaminhoArquivo();
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            EscreverArquivo();
        }

        private void txtLocalizar_TextChanged(object sender, EventArgs e)
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

        private void gdvBuscaPreco_RowCountChanged(object sender, EventArgs e)
        {
            linha = Convert.ToInt32(this.gdvBuscaPreco.RowCount.ToString());
            lblContador.Visible = true;
            lblItensExibicao.Visible = true;
            this.lblContador.Text = linha.ToString().PadLeft(9, '0');
        }
    }
}

