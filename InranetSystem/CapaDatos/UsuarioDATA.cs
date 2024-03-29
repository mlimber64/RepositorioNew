﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
   public class UsuarioDATA
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader dr;
        Conexion cn = new Conexion();
        private string errores;

        public IEnumerable<Usuario> Login(string usu, string pass)
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                conexion = cn.Conectar();
                cmd = new SqlCommand("USP_DBTEST_LOGIN_USUARIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@insUsuario", usu);
                cmd.Parameters.AddWithValue("@insContrasena", pass);

                dr = null;
                conexion.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Usuario objeto = new Usuario();
                    objeto.email = Convert.ToString(dr["email"]);
                    objeto.Contrasena = Convert.ToString(dr["contrasena"]);
                    objeto.nombreCompleto = Convert.ToString(dr["nombreCompleto"]);

                    lista.Add(objeto);

                }
                dr.Close();
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

