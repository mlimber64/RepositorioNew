using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class VentaMANAGER
    {
        VentaDATA data = new VentaDATA();
        public IEnumerable<Venta> listarVenta()
        {
            return data.listarVenta();
        }
    }
}
