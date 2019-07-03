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
    public class UsuarioController : Controller
    {
        // GET: Usuario

        UsuarioMANAGER managerUsuario = new UsuarioMANAGER();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            if (Request.Cookies["Usuario"] != null)
            {
                Response.Cookies["Usuario"].Expires = DateTime.Now.AddDays(-1);
            }
            if (Request.Cookies["NombreUsuario"] != null)
            {
                Response.Cookies["NombreUsuario"].Expires = DateTime.Now.AddDays(-1);

            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(string usu, string pass)
        {
            IEnumerable<Usuario> objeto = null;
            objeto = managerUsuario.Login(usu, pass);
            if (objeto.Count() == 0)
            {
                return View();
            }
            else
            {
                Response.Cookies["Usuario"].Value = objeto.ElementAt(0).nomUsuario.ToString();
                Response.Cookies["NombreUsuario"].Value = objeto.ElementAt(0).Nombre.ToString();
                Response.Cookies["Usuario"].Expires = DateTime.Now.AddDays(1);
                Response.Cookies["NombreUsuario"].Expires = DateTime.Now.AddDays(1);

                return RedirectToAction("Index", "Home");
            }
        }
    }
}