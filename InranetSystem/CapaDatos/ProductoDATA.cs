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
                    objeto.tipo = Convert.ToString(dr["Nombre"]);
                    objeto.nombre = Convert.ToString(dr["Nombre"]);
                    objeto.descripcion = Convert.ToString(dr["Descripcion"]);
                    objeto.precioCompra = Convert.ToString(dr["PrecioUnitario"]);
                    objeto.precioVenta = Convert.ToString(dr["nombreC"]);
                    objeto.stockActual = Convert.ToString(dr["Stock"]);
                    objeto.stockMinino = Convert.ToString(dr["Imagen"]);
                    

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
        public Boolean RegistrarProducto(string codigo, string nombre, string preuni, string categ, string descri, string stock, string imagen)
        {
            try
            {
                conexion = cn.Conectar();
                SqlCommand cmd = new SqlCommand("USP_ERPGES_I_CATEGORIAPRODUCTO", conexion);


                //Definimos los parámetros de entrada

                cmd.Parameters.AddWithValue("_Cate_Categ_Id_Padre", codigo);
                cmd.Parameters.AddWithValue("_Cate_Nombre", nombre);
                cmd.Parameters.AddWithValue("_Cate_Descri", preuni);
                cmd.Parameters.AddWithValue("_Cat_Imagen", categ);
                cmd.Parameters.AddWithValue("_Cate_Categ_Id_Padre", descri);
                cmd.Parameters.AddWithValue("_Cate_Nombre", stock);
                cmd.Parameters.AddWithValue("_Cat_Imagen", imagen);

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
    }
}
