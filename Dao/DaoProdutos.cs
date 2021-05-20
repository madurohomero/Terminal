using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using Security;
using Common;
using System.Windows.Forms;
using Entity;

namespace Dao
{
    public class DaoProdutos
    {
        #region[Objetos/Variaveis]
        private SqlConnection _con;
        private SqlCommand _command;

        DTICrypto objCrypto = new DTICrypto();
        #endregion
        #region[Listar Produtos do Busca Preço]
        public List<Produto> obterLista(bool showAll, LinkLabel lnklbl)
        {
            List<Produto> produto = new List<Produto>();
            _con = new SqlConnection() { ConnectionString = objCrypto.Decrypt(Conexao.stringDeConexao, Mensagens.VETOR_INICIALIZACAO) };
            int number;
            StringBuilder sb = new StringBuilder();
            if (showAll)
            {
                sb.Append("SELECT BARCODE, PRODUCT, PRICE ");
                sb.Append("FROM V_BUSCAPRECO");
            }
            _con.Open();
            _command = new SqlCommand(sb.ToString(), _con);
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                lnklbl.Visible = false;
                while (reader.Read())
                {
                    try
                    {
                        Produto prod = new Produto()
                        {
                            codigoDeBarra = reader["BARCODE"].ToString(),
                            descricao = reader["PRODUCT"].ToString(),
                            preco = reader["PRICE"].ToString()

                        };
                        produto.Add(prod);
                    }
                    catch (FormatException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
            else
            {
                lnklbl.Visible = true;
            }
            _con.Close();
            return produto;
        }
        #endregion


        public Produto recuperarPorId(int codigo)
        {
            _con = new SqlConnection() { ConnectionString = objCrypto.Decrypt(Conexao.stringDeConexao, Mensagens.VETOR_INICIALIZACAO) };
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM produtos ");
            sb.Append("WHERE codigo = @codigo");
            _command = new SqlCommand(sb.ToString(), _con);
            _command.Parameters.AddWithValue("@codigo", codigo);
            try
            {
                _con.Open();
                SqlDataReader reader = _command.ExecuteReader();
                Produto prod = null;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        prod = new Produto();
                        prod.codigo = Convert.ToInt32(reader["CODIGO"].ToString());
                        prod.codigoDeBarra = reader["CODBARRA"].ToString();
                        prod.descricao = reader["DESCRICAO"].ToString();
                        prod.preco = reader["PRECO"].ToString();
                    }
                }

                return prod;
            }
            catch (SqlException ex)
            {
                throw new Exception("ERRO BANCO DE DADOS: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO RUNTIME: " + ex.Message);
            }
            finally
            {
                _con.Close();
            }
        }




        public void incluir(Produto prod)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand command;
            const string query = "Select @@Identity";
            conn.ConnectionString = Conexao.stringDeConexao;

            string sql = "INSERT INTO produtos (codbarra, descricao, preco) values (@codbarra, @descricao, @preco);";
            if (prod.codigo != 0)
            {
                sql = "UPDATE produtos SET codbarra = @codbarra, descricao = @descricao, preco = @preco WHERE codigo = @codigo";
            }
            using (command = new OleDbCommand(sql, conn))
            {
                command.Parameters.AddWithValue("@codbarra", prod.codigoDeBarra);
                command.Parameters.AddWithValue("@descricao", prod.descricao);
                command.Parameters.AddWithValue("@preco", prod.preco);
                try
                {
                    conn.Open();
                    if (prod.codigo == 0)
                    {
                        command.ExecuteNonQuery();
                        command.CommandText = query;
                        prod.codigo = Convert.ToInt32(command.ExecuteScalar());
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@codigo", prod.codigo);
                        command.ExecuteNonQuery();
                    }
                }
                catch (OleDbException ex)
                {
                    throw new Exception("ERRO BANCO DE DADOS: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("ERRO RUNTIME: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    command.Dispose();
                }
            }

        }

        public void excluir(int codigo)
        {
            OleDbConnection conn = new OleDbConnection() { ConnectionString = Conexao.stringDeConexao };
            StringBuilder sb = new StringBuilder();
            sb.Append("DELETE FROM produtos ");
            sb.Append("WHERE codigo = @codigo;");
            OleDbParameter param = new OleDbParameter("@codigo", codigo);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Parameters.Add(param);
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sb.ToString();
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                throw new Exception("ERRO BANCO DE DADOS: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO RUNTIME: " + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
