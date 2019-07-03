using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   public class UsuarioMANAGER
    {
        UsuarioDATA data = new UsuarioDATA();

        public IEnumerable<Usuario> Login(string usu, string pass)
        {
            return data.Login(usu, pass);
        }
    }
}
