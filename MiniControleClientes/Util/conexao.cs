using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MiniControleClientes.Util
{
    public class conexao
    {
        public static string ObterConexao()
        {
            return ConfigurationManager.ConnectionStrings["CadastroUninove"].ConnectionString;
        }
    }
}
