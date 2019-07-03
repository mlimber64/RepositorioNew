using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

namespace CapaDatos
{
   public class Conexion
    {
        SqlConnection conexion;
        public SqlConnection Conectar()
        {
            conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            return conexion;
        }
    }
}
