using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   public class ProductoMANAGER
    {
        ProductoDATA data = new ProductoDATA();
        public IEnumerable<Producto> listarProducto()
        {
            return data.listarProducto();
        }
        public Boolean RegistrarProducto(string codigo, string nombre, string preuni, string categ, string descri, string stock, string imagen)
        {
            return data.RegistrarProducto(codigo,nombre,preuni,categ,descri,stock, imagen);
        }
    }
}
