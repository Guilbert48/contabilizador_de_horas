using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace contabilizador_de_horas
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao() 
        {
            con.ConnectionString = "Data Source=DESKTOP-RVMH717;Initial Catalog=Contador_dba;Integrated Security=True;Encrypt=False"; 
        }
        public SqlConnection Conectar()
        {
            return con;
        }

    }
}
