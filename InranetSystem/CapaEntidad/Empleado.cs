using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class Empleado
    {
        public int EmpleadoID { set; get; }
        public string Apellido { set; get; }
        public string Nombre { set; get; }
        public string Titulo { set; get; }
        public string FechaNaci { set; get; }
        public string Direccion { set; get; }
        public string Ciudad { set; get; }
        public string Telefono { set; get; }
        public string Foto { set; get; }
    }
}
