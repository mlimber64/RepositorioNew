using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int idVenta { set; get; }
        public int idProducto { set; get; }
        public string precioUnitario { set; get; }
        public int cantidad { set; get; }
        public string subTotal { set; get; }
        public string IGV { set; get; }
        public string total { set; get; }
    }
}
