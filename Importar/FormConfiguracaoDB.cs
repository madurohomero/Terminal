using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dao;
using Common;
using System.Data.SqlClient;

namespace Importar
{
    public partial class FormConfiguracaoDB : Form
    {
        #region[Objetos/Variaveis]
        AppConfigString config = new AppConfigString();
        SqlConnection con;
        #endregion
        #region[Conexão]
        private static string GetConexao(string servidor, string user, string senha, string banco)
        {
            string conexao = string.Format("server = {0}; user = {1}; pwd = {2}; database = {3};", servidor, user, senha, banco);
            return conexao;
        }
        #endregion
        #region[Construtor]
        public FormConfiguracaoDB()
        {
            InitializeComponent();
        }
        #endregion
        #region[Método Público Testar Canexão]
        public void testarConexao()
        {
            string servidor = txtServer.Text;
            string user = txtUsuario.Text;
            string senha = txtSenha.Text;
            string banco = txtDb.Text;
            string conexao = GetConexao(servidor, user, senha, banco);
            con = new SqlConnection(conexao);
            try
            {
                con.Open();
                txtTesteConexao.Text = Mensagens.TESTE_OK;
                txtTesteConexao.Visible = true;
                statusOk.Visible = true;
                statusFalhou.Visible = false;
            }
            catch (SqlException mysqlex)
            {
                txtTesteConexao.Text = Mensagens.TESTE_FALHOU;
                txtTesteConexao.Visible = true;
                statusFalhou.Visible = true;
                statusOk.Visible = false;
                MessageBox.Show(string.Format(Mensagens.TESTE_CONEXAO, mysqlex.Message), "Teste de conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                testarConexao();
            }
            else
            {
                try
                {
                    testarConexao();
                    if (con.State == ConnectionState.Open)
                    {
                        config.SalvarConexaoMySql(txtServer.Text, txtUsuario.Text, txtSenha.Text, txtDb.Text);
                        Close();
                        Application.Restart();
                    }
                }
                catch (SqlException mysqlex)
                {
                    MessageBox.Show(string.Format(Mensagens.TESTE_CONEXAO, mysqlex.Message), "Teste de conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnTesteConexao_Click(object sender, EventArgs e)
        {
            testarConexao();
        }

        private void btnEditarDados_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensagens.EDITAR_CONFIGURACAO_PADRAO, "Alterar Configuração Padrão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtDb.Enabled = true;
                txtUsuario.Enabled = true;
                txtDb.Select();
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSenha.Text))
            {
                btnTesteConexao.Enabled = true;

            }
            else
            {
                btnTesteConexao.Enabled = false;
                txtTesteConexao.Visible = false;
                statusOk.Visible = false;
                statusFalhou.Visible = false;
            }
        }

        private void txtServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtDb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUsuario.Focus();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtServer_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }
    }
}
