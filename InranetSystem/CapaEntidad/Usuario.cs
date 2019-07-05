using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int idUsuario { set; get; }
        public string email { set; get; }
        public string Contrasena { set; get; }
        public string Nombre { set; get; }
        public string ApellidoCompleto { set; get; }
        public string nombreCompleto { set; get; }
        public string Telefono { set; get; }
    }
}
