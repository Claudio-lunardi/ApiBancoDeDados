using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBancoDeDados.Database
{
    internal class ConexaoSqlServer
    {
        public static SqlConnection Conectar()
        {
            string connectionString = "Data Source=bd.thor.hostazul.com.br,3533;User ID=139_claudio;Password=xgzejtvys2nlimdcauhk;Initial Catalog=139_claudio;";
            //string connectionString = "Data Source=localhost,1433;User ID=sa;Password=senha@1234xxxY;Initial Catalog=DevPraticaPDVAtualizado;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

