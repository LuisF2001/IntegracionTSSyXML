using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Practica2
{
    class Conexion
    {
        public static SqlConnection getConnection()
        {
            SqlConnection ocon = new SqlConnection("server=ASUS-ROG-STRIX-\\MSSQLSERVER2017;integrated security=true; database=TSS");
            ocon.Open();
            return ocon;
        }
    }
}