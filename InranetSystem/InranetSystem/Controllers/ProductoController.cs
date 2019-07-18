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
        CategoriaMANAGER managerCategoria = new CategoriaMANAGER();
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
        public ActionResult Producto()
        {
            IEnumerable<Producto> objeto = null;
            objeto = managerProducto.listarProducto();
            ViewBag.Categoria = new SelectList(managerCategoria.listarCategoria(), "idCategoria", "Nombre");
            return View(objeto);
        }

        [HttpPost]
        public ActionResult sendFile(HttpPostedFileBase file)
        {
            //subir imagen
            if (file.ContentLength > 0)
            {
                string _FileName = Path.GetFileName(file.FileName);
                string _path = Path.Combine(Server.MapPath("~/images"), _FileName);
                file.SaveAs(_path);
            }
            String msg = "exito";
            return Json(new { msg });
        }

        [HttpPost]
        public ActionResult UploadFiles()
        {
            // Checking no of files injected in Request object  
            if (Request.Files.Count > 0)
            {
                try
                {
                    //  Get all files from Request object  
                    HttpFileCollectionBase files = Request.Files;
                    for (int i = 0; i < files.Count; i++)
                    {
                        //string path = AppDomain.CurrentDomain.BaseDirectory + "Uploads/";  
                        //string filename = Path.GetFileName(Request.Files[i].FileName);  

                        HttpPostedFileBase file = files[i];
                        string fname;

                        // Checking for Internet Explorer  
                        if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                        {
                            string[] testfiles = file.FileName.Split(new char[] { '\\' });
                            fname = testfiles[testfiles.Length - 1];
                        }
                        else
                        {
                            fname = file.FileName;
                        }

                        // Get the complete folder path and store the file inside it.  
                        fname = Path.Combine(Server.MapPath("~/images/"), fname);
                        file.SaveAs(fname);

                        string codigo = Request["codigo"];
                        string nombre = Request["nombre"];
                        string preuni = Request["preuni"];
                        string categ = Request["categ"];
                        string descri = Request["descri"];
                        string stock = Request["stock"];
                        string imagen = Request["imagen"];

                        managerProducto.RegistrarProducto(codigo, nombre, preuni, categ, descri, stock, imagen);

                    }
                    // Returns message that successfully uploaded  
                    return Json("Exito");
                }
                catch (Exception ex)
                {
                    return Json("Error occurred. Error details: " + ex.Message);
                }

            }
            else
            {
                string codigo = Request["codigo"];
                string nombre = Request["nombre"];
                string preuni = Request["preuni"];
                string categ = Request["categ"];
                string descri = Request["descri"];
                string stock = Request["stock"];
                string imagen = Request["imagen"];

                managerProducto.RegistrarProducto(codigo, nombre, preuni, categ, descri, stock, imagen);

                return Json("Exito");
            }
        }

    }
}