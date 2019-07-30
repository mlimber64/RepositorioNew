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
    public class ClienteController : Controller
    {
        // GET: Cliente
        ClienteMANAGER managerCliente = new ClienteMANAGER();
        public ActionResult IndexCliente()
        {
            IEnumerable<Cliente> objeto = null;
            objeto = managerCliente.listarCliente();
            
            return View(objeto);
        }
        public JsonResult ListAjax()
        {
            IEnumerable<Cliente> objeto = null;

            objeto = managerCliente.listarCliente();

            return Json(objeto);
        }
        public JsonResult CreateCliente(string nombre, string apepat, string apemat, string telef, string dni)
        {

            try
            {
                managerCliente.RegistrarCliente(nombre, apepat, apemat, telef, dni);
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