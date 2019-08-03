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
    public class DetalleVentaController : Controller
    {
        // GET: DetalleVenta
        DetalleVentaMANAGER managerDetVenta = new DetalleVentaMANAGER();
        public ActionResult IndexDetVenta()
        {
            IEnumerable<DetalleVenta> objeto = null;
            objeto = managerDetVenta.listarDetVenta();
            return View(objeto);
        }
    }
}