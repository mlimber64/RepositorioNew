using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace InranetSystem.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        ProductoMANAGER managerProducto = new ProductoMANAGER();
        //CategoriaMANAGER managerCategoria = new CategoriaMANAGER();
        TipoProductoMANAGER managerTipoProducto = new TipoProductoMANAGER();
        int numreg = 5;
        public ActionResult IndexProducto(int? pag = null)
        {
            IEnumerable<Producto> listaTotal = null;
            listaTotal = managerProducto.listarProducto();
            //recupero la cantidad de registros y almaceno el numero de registro
            int c = managerProducto.listarProducto().Count();
            ViewBag.numreg = c % numreg != 0 ? c / numreg + 1 : c / numreg;

            //definir la pagina actual, el reg de inicio y el reg final
            int pageact = pag == null ? 0 : (int)pag;
            int reginicio = pageact * numreg;
            int regfin = reginicio + numreg;

            //variable que almacenara los clientes para la paginación
            List<Producto> lista = new List<Producto>();
            for (int i = reginicio; i < regfin; i++)
            {
                if (i == c) break; //si i es igual a numero de reg salir
                lista.Add(listaTotal.ToList()[i]);
            }
            
            return View(lista);
        }
        
        public ActionResult IndexProductos()
        {
            IEnumerable<Producto> objeto = null;
            objeto = managerProducto.listarProducto();
            ViewBag.TipoProducto = new SelectList(managerTipoProducto.listarTipoProducto(), "idTipo", "Nombre");
            return View(objeto);
        }
        public JsonResult ListAjax()
        {
            IEnumerable<Producto> objeto = null;

            objeto = managerProducto.listarProducto();

            return Json(objeto);
        }
        public JsonResult CreateProducto(string tipo, string nombre, string desc, string prcom, string prvent, string stockact, string stockmin)
        {

            try
            {
                managerProducto.RegistrarProducto(tipo, nombre, desc, prcom, prvent, stockact, stockmin);
                string msg = "Exito se guardo controller";
                return Json(new { msg });

            }
            catch (Exception e)
            {
                string msg = "Error";
                return Json(new { msg });
            }

        }


    }
}