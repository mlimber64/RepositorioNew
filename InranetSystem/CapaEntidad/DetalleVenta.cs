using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class DetalleVenta
    {
        public int idVenta { set; get; }
        public int idProducto { set; get; }
        public int cantidad { set; get; }
        public string precio { set; get; }
        public string total { set; get; }
    }
}
