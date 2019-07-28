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
    public class DetalleVentaDATA
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader dr;
        Conexion cn = new Conexion();
        private string errores;
        public IEnumerable<DetalleVenta> listarDetVenta()
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();
            try
            {
                conexion = cn.Conectar();
                cmd = new SqlCommand("SP_DBTEST_S_DETALLEVENTA", conexion);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dr = null;
                conexion.Open();
                dr = cmd.ExecuteReader();
                DetalleVenta objeto = null;
                while (dr.Read())
                {
                    objeto = new DetalleVenta();

                    objeto.idVenta = Convert.ToInt32(dr["Tipo"]);
                    objeto.idProducto = Convert.ToInt32(dr["idProducto"]);
                    objeto.cantidad = Convert.ToInt32(dr["Nombre"]);
                    objeto.precio = Convert.ToString(dr["Descripcion"]);
                    objeto.total = Convert.ToString(dr["PrecioCompra"]);


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

