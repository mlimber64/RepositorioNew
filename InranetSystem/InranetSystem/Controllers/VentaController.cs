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
    public class VentaController : Controller
    {
        // GET: Venta
        VentaMANAGER managerVenta = new VentaMANAGER();
        TipoProductoMANAGER managerTipoProducto = new TipoProductoMANAGER();
        ProductoMANAGER managerProducto = new ProductoMANAGER();
        public ActionResult IndexVenta()
        {
            IEnumerable<Venta> objeto = null;
            objeto = managerVenta.listarVenta();
            ViewBag.TipoProducto = new SelectList(managerTipoProducto.listarTipoProducto(), "idTipo", "Nombre");
            ViewBag.Producto = new SelectList(managerProducto.listarProducto(), "idProducto", "Nombre");

            return View(objeto);
        }
        public JsonResult ComboProducto(int id)
        {

            IEnumerable<Producto> objeto = null;

            try
            {
                objeto = managerProducto.ComboProducto(id);
                string msg = "Se obtuvo el registro";
                return Json(new { msg, objeto });
            }
            catch (Exception e)
            {
                string msg = "Error";
                return Json(new { msg });
            }

        }
    }
}