using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Dao
{
    public class Conexao
    {

        public static string stringDeConexao
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["stringDeConexao"].ConnectionString;
            }
        }
    }
}
