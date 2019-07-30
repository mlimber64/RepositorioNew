using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   public class TipoProductoMANAGER
    {
        TipoProductoDATA data = new TipoProductoDATA();
        public IEnumerable<TipoProducto> listarTipoProducto()
        {
            return data.listarTipoProducto();
        }
    }
}
