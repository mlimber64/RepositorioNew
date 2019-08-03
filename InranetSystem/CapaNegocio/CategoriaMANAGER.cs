using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   public class CategoriaMANAGER
    {
        CategoriaDATA data = new CategoriaDATA();
        public IEnumerable<Categoria> listarCategoria()
        {
            return data.listarCategoria();
        }
    }
}
