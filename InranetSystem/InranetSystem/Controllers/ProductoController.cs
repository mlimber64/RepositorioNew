using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace InranetSystem.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        ProductoMANAGER managerProducto = new ProductoMANAGER();
        int numreg = 5;
        public ActionResult IndexProducto()
        {
            IEnumerable<Producto> objeto = null;
            objeto = managerProducto.listarProducto();
            return View(objeto);
        }
        public ActionResult IndexProductos(int? pag = null)
        {
            var lista = managerProducto.listarProducto();
            int c = lista.Count();
            ViewBag.numreg = c % numreg != 0 ? c / numreg + 1 : c / numreg;

            int pageact = pag == null ? 0 : (int)pag;
            int reginicio = pageact * numreg;
            int regfin = reginicio + numreg;
            List<Producto> listado = new List<Producto>();

            for (int i = reginicio; i < regfin; i++)
            {
                if (i == c) break;
                listado.Add(listado[i]);
            }

            return View(lista);
        }
    }
}