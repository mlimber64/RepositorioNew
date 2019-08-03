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
        public Boolean RegistrarProducto(string tipo, string nombre, string desc, string prcom, string prvent, string stockact, string stockmin)
        {
            return data.RegistrarProducto(tipo, nombre, desc, prcom, prvent, stockact, stockmin);
        }
        public IEnumerable<Producto> ComboProducto(int id)
        {
            return data.ComboProducto(id);
        }
    }
}
