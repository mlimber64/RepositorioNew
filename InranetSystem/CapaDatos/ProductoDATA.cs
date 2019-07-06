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
   public class ProductoDATA
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader dr;
        Conexion cn = new Conexion();
        private string errores;

        public IEnumerable<Producto> listarProducto()
        {
            List<Producto> lista = new List<Producto>();
            try
            {
                conexion = cn.Conectar();
                cmd = new SqlCommand("SP_DBINTRANET_S_PRODUCTO", conexion);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dr = null;
                conexion.Open();
                dr = cmd.ExecuteReader();
                Producto objeto = null;
                while (dr.Read())
                {
                    objeto = new Producto();
                    objeto.idProducto = Convert.ToInt32(dr["idProducto"]);
                    objeto.codigo = Convert.ToString(dr["Codigo"]);
                    objeto.nombre = Convert.ToString(dr["Nombre"]);
                    objeto.precioUnitario = Convert.ToString(dr["PrecioUnitario"]);
                    objeto.nombreC = Convert.ToString(dr["nombreC"]);
                    objeto.descripcion = Convert.ToString(dr["Descripcion"]);
                    objeto.stock = Convert.ToInt32(dr["Stock"]);
                    objeto.imagen = Convert.ToString(dr["Imagen"]);
                    

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
