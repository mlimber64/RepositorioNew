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
    public class ClienteDATA
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader dr;
        Conexion cn = new Conexion();
        private string errores;

        public IEnumerable<Cliente> listarCliente()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                conexion = cn.Conectar();
                cmd = new SqlCommand("SP_DBTEST_S_CLIENTE", conexion);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dr = null;
                conexion.Open();
                dr = cmd.ExecuteReader();
                Cliente objeto = null;
                while (dr.Read())
                {
                    objeto = new Cliente();
                    objeto.idCliente = Convert.ToInt32(dr["idCliente"]);
                    objeto.nombres = Convert.ToString(dr["Nombre"]);
                    objeto.nomCom = Convert.ToString(dr["nomCom"]);
                    //objeto.apePaterno = Convert.ToString(dr["ApellidoPaterno"]);
                    //objeto.apeMaterno = Convert.ToString(dr["ApellidoMaterno"]);
                    objeto.telefono = Convert.ToString(dr["Telefono"]);
                    objeto.dni = Convert.ToInt32(dr["DNI"]);


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
        public Boolean RegistrarCliente(string nombre, string apepat, string apemat, string telef, string dni)
        {
            try
            {
                conexion = cn.Conectar();
                SqlCommand cmd = new SqlCommand("SP_DBTEST_I_CLIENTE", conexion);


                //Definimos los parámetros de entrada

                cmd.Parameters.AddWithValue("@insnombre", nombre);
                cmd.Parameters.AddWithValue("@insappat", apepat);
                cmd.Parameters.AddWithValue("@insapmat", apemat);
                cmd.Parameters.AddWithValue("@instelf", telef);
                cmd.Parameters.AddWithValue("@insdni", dni);
                

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
