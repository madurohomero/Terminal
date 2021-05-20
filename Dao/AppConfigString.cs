using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Security;
using System.Data.SqlClient;
using System.Configuration;
using Common;

namespace Importar
{
    public class AppConfigString
    {
        DTICrypto objCrypto = new DTICrypto();
        const string nomeConexao = "stringDeConexao";
        const string nomeBackup = "backup";
        const string nomeLicenca = "licenca";
        const string nomeCaminho = "caminhoArquivo";
        private readonly Configuration pcfgConfiguration =
            ConfigurationManager.OpenExeConfiguration(AppDomain.CurrentDomain.BaseDirectory + "Importar.exe");



        public bool configurarCaminhoArquivo(string key, string strValue)
        {
            try
            {
                var settings = pcfgConfiguration.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(nomeCaminho, strValue);
                }
                else
                {
                    settings[key].Value = strValue;
                }
                pcfgConfiguration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(pcfgConfiguration.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                throw new Exception("Erro ao escrever app settings.");
            }

            return false;
        }
        public bool RecuperarValoresConexao(string strNomeConexao)
        {
            bool result = false;
            try
            {
                if (ConfigurationManager.OpenExeConfiguration(AppDomain.CurrentDomain.BaseDirectory + "Importar.exe").ConnectionStrings.ConnectionStrings[strNomeConexao] != null)
                {
                    string lstrConexao = ConfigurationManager.OpenExeConfiguration(AppDomain.CurrentDomain.BaseDirectory + "Importar.exe").ConnectionStrings.ConnectionStrings[strNomeConexao].ConnectionString;
                    List<String> lstDadosConexao = new List<string>(lstrConexao.Split(new[] { '=', ';' }));
                    for (int indice = 0; indice < lstDadosConexao.Count; indice += 2)
                    {
                        lstDadosConexao[indice] = "";
                    }
                    lstDadosConexao.RemoveAll(Predicate => Predicate == "");
                }
                result = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return result;
            }
            return result;
        }

        public void ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result1 = appSettings[key] ?? "Not Found";
                Console.WriteLine(result1);
            }
            catch (ConfigurationErrorsException)
            {

                Console.WriteLine("Erro de leitura na configuração do aplicativo");
            }
        }

        public bool salvarRegistro(string key, string strValue)
        {
            try
            {
                var settings = pcfgConfiguration.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(nomeBackup, strValue);
                }
                else
                {
                    settings[key].Value = strValue;
                }
                pcfgConfiguration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(pcfgConfiguration.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                throw new Exception("Erro ao escrever app settings.");
            }

            return false;
        }

        public bool configurarCaminhoBackup(string key, string strValue)
        {
            try
            {
                var settings = pcfgConfiguration.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(nomeBackup, strValue);
                }
                else
                {
                    settings[key].Value = strValue;
                }
                pcfgConfiguration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(pcfgConfiguration.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                throw new Exception("Erro ao escrever app settings.");
            }

            return false;
        }

        public bool SalvarConexaoMySql(string strDataSource, string strUserId, string strSenha, string strBancoDados)
        {
            bool result = false;
            try
            {
                SqlConnectionStringBuilder conBuilder = new SqlConnectionStringBuilder() { DataSource = strDataSource, UserID = strUserId, Password = strSenha, InitialCatalog = strBancoDados };
                if (RecuperaValorConexao(nomeConexao) != null)
                    result = false;
                // Criar Conexão
                pcfgConfiguration.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings { Name = nomeConexao, ConnectionString = objCrypto.Encrypt(conBuilder.ConnectionString, Mensagens.VETOR_INICIALIZACAO), ProviderName = "System.Data.SqlClient" });
                // Salvar Conexão
                pcfgConfiguration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(nomeConexao);
                result = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public string RecuperaValorConexao(string stringConexao)
        {
            try
            {
                return pcfgConfiguration.ConnectionStrings.ConnectionStrings[stringConexao].ToString();
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
