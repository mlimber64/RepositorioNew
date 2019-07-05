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
   public class EmpleadosDATA
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader dr;
        Conexion cn = new Conexion();
        private string errores;

        public IEnumerable<Empleado> listarEmpleado()
        {
            List<Empleado> lista = new List<Empleado>();
            try
            {
                conexion = cn.Conectar();
                cmd = new SqlCommand("USP_BASETEST_S_EMPLEADO", conexion);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dr = null;
                conexion.Open();
                dr = cmd.ExecuteReader();
                Empleado objCateg = null;
                while (dr.Read())
                {
                    objCateg = new Empleado();
                    objCateg.EmpleadoID = Convert.ToInt32(dr["EmpleadoID"]);
                    objCateg.Nombre = Convert.ToString(dr["Nombre"]);
                    objCateg.Apellido = Convert.ToString(dr["Apellido"]);
                    objCateg.Titulo = Convert.ToString(dr["Titulo"]);
                    objCateg.FechaNaci = Convert.ToString(dr["FechaNaci"]);
                    objCateg.Direccion = Convert.ToString(dr["Direccion"]);
                    objCateg.Ciudad = Convert.ToString(dr["Ciudad"]);
                    objCateg.Telefono = Convert.ToString(dr["Telefono"]);
                    objCateg.Foto = Convert.ToString(dr["Foto"]);
                    lista.Add(objCateg);
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

