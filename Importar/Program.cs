using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Data.SqlClient;
using System.Data;
using Dao;
using Common;
using Security;
using System.Configuration;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace Importar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        private const string nomeConexao = "stringDeConexao";

        [STAThread]


        static void Main()
        {

            Assembly sampleAssembly;
            int num = 0;
            string[] fileName = { "Security.dll" };
            // string file = string.Join(", ", fileName);
            for (int i = 0; i < fileName.Length; i++)
            {
                if (File.Exists(fileName[i]))
                {
                    sampleAssembly = Assembly.LoadFile(Path.GetFullPath(fileName[i]));

                    num++;
                }
            }
            if (num != fileName.Length)
            {
                MessageBox.Show("Por favor verifique o(s) arquivo(s) dlls", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con;
            DTICrypto objCrypto = new DTICrypto();
            if (ConfigurationManager.OpenExeConfiguration(AppDomain.CurrentDomain.BaseDirectory + "Importar.exe").ConnectionStrings.ConnectionStrings[nomeConexao] == null)
            {
                Application.Run(new FormConfiguracaoDB());
                return;
            }
            Process aProcess = Process.GetCurrentProcess();
            string aProcName = aProcess.ProcessName;
            if (Process.GetProcessesByName(aProcName).Length > 1)
            {

                MessageBox.Show(Mensagens.AGUARDE_SISTEMA, "Eccus Informática Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                using (con = new SqlConnection(objCrypto.Decrypt(Conexao.stringDeConexao, Mensagens.VETOR_INICIALIZACAO)))
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        DevExpress.Skins.SkinManager.EnableFormSkins();
                        UserLookAndFeel.Default.SetSkinStyle("Seven");

                        Application.Run(new FormPrincipal());
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na conexão com o Banco de Dados, Verifique!", "Erro Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}