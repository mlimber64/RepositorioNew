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
   public class CategoriaDATA
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader dr;
        Conexion cn = new Conexion();
        private string errores;

        public IEnumerable<Categoria> listarCategoria()
        {
            List<Categoria> lista = new List<Categoria>();
            try
            {
                conexion = cn.Conectar();
                cmd = new SqlCommand("SP_DBINTRANET_S_CATEGORIA", conexion);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dr = null;
                conexion.Open();
                dr = cmd.ExecuteReader();
                Categoria objeto = null;
                while (dr.Read())
                {
                    objeto = new Categoria();
                    objeto.idCategoria = Convert.ToInt32(dr["idCategoria"]);
                    objeto.nombre = Convert.ToString(dr["Nombre"]);
                    objeto.descripcion = Convert.ToString(dr["Descripcion"]);


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
