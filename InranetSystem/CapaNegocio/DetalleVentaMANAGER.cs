using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class DetalleVentaMANAGER
    {
        DetalleVentaDATA data = new DetalleVentaDATA();
        public IEnumerable<DetalleVenta> listarDetVenta()
        {
            return data.listarDetVenta();
        }
    }
}
