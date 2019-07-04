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
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        EmpleadoMANAGER managerEmpleado = new EmpleadoMANAGER();
        public ActionResult Index()
        {
            IEnumerable<Empleado> objeto = null;
            objeto = managerEmpleado.listarEmpleado();
            return View(objeto);
        }
    }
}