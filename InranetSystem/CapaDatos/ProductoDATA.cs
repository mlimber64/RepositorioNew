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
                cmd = new SqlCommand("SP_DBTEST_S_PRODUCTO", conexion);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dr = null;
                conexion.Open();
                dr = cmd.ExecuteReader();
                Producto objeto = null;
                while (dr.Read())
                {
                    objeto = new Producto();
                    objeto.idProducto = Convert.ToInt32(dr["idProducto"]);
                    objeto.Tipo = Convert.ToString(dr["idProducto"]);
                    objeto.nombre = Convert.ToString(dr["Nombre"]);
                    objeto.descripcion = Convert.ToString(dr["Descripcion"]);
                    objeto.precioCompra = Convert.ToString(dr["PrecioCompra"]);
                    objeto.precioVenta = Convert.ToString(dr["PrecioVenta"]);
                    objeto.stockActual = Convert.ToString(dr["StockActual"]);
                    objeto.stockMinino = Convert.ToString(dr["StockMin"]);
                    

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
        public Boolean RegistrarProducto(string tipo, string nombre, string desc, string prcom, string prvent, string stockact, string stockmin)
        {
            try
            {
                conexion = cn.Conectar();
                SqlCommand cmd = new SqlCommand("SP_DBTEST_I_PRODUCTO", conexion);


                //Definimos los parámetros de entrada

                cmd.Parameters.AddWithValue("@instipo", tipo);
                cmd.Parameters.AddWithValue("@insnombre", nombre);
                cmd.Parameters.AddWithValue("@insdesc", desc);
                cmd.Parameters.AddWithValue("@insprcom", prcom);
                cmd.Parameters.AddWithValue("@insprvent", prvent);
                cmd.Parameters.AddWithValue("@insstockact", stockact);
                cmd.Parameters.AddWithValue("@insstockmin", stockmin);

                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                errores = ex.Message;
                return false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion = null;
                cmd = null;
                cn = null;
            }
        }
        public IEnumerable<Producto> ComboProducto(int id)
        {
            List<Producto> lista = new List<Producto>();
            try
            {
                conexion = cn.Conectar();
                cmd = new SqlCommand("SP_DBTEST_S_COMBOPRODUCTO", conexion);
                cmd.Parameters.AddWithValue("@cboid", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dr = null;
                conexion.Open();
                dr = cmd.ExecuteReader();
                Producto objeto = null;
                while (dr.Read())

                {


                    objeto = new Producto();
                    objeto.idProducto = Convert.ToInt32(dr["idProducto"]);
                    objeto.nombre = Convert.ToString(dr["Nombre"]);


                    //agregamos a las lista
                    lista.Add(objeto);

                }
            }
            catch (Exception ex)
            {
                errores = ex.Message;

            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();

                }
                conexion.Dispose();
            }

            return lista;
        }
    }
}
