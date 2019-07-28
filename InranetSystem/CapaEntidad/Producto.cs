using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class Producto
    {
       public int idProducto { set; get; }
       public string Tipo { set; get; }
       public string nombre { set; get; }
       public string descripcion { set; get; }
       public string precioCompra { set; get; }
       public string precioVenta { set; get; } 
       public string stockActual { set; get; } 
       public string stockMinino { set; get; } 
       public Boolean activo { set; get; } 



      

    }
}
