using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
   public  class VentaDATA
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader dr;
        Conexion cn = new Conexion();
        private string errores;

        public IEnumerable<Venta> listarVenta()
        {
            List<Venta> lista = new List<Venta>();
            try
            {
                conexion = cn.Conectar();
                cmd = new SqlCommand("SP_DBTEST_S_VENTA", conexion);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dr = null;
                conexion.Open();
                dr = cmd.ExecuteReader();
                Venta objeto = null;
                while (dr.Read())
                {
                    objeto = new Venta();
                    objeto.idVenta = Convert.ToInt32(dr["idVenta"]);
                    objeto.nombapells = Convert.ToString(dr["apellido"]);
                    objeto.total = Convert.ToString(dr["Total"]);
                    
                    lista.Add(objeto);
                }
            }
            catch (Exception e)
            {
                errores = e.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
                cmd.Dispose();
            }
            return lista;
        }
    }
}
