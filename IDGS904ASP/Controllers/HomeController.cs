using IDGS904ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904ASP.Controllers
{
    public class HomeController : Controller
    {
        /*
        public ActionResult Index()
          {
              return View();
          }
        */

        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /* 
        // Devuelve solo texto
        public ContentResult Index()
        {
            return Content("Karla IDGS905");
        }
        */

        /*
        // Devuelve siempre una vista
        public ViewResult Index()
        {
            return View();
        }
        */

        /*
        // para regresar una cadena de texto json
        public JsonResult Index()
        {
            var alumno1 = new Persona() { Nombre = "Karla", Edad = 21, Empleado = true };
            var alumno2 = new Persona() { Nombre = "Paulo", Edad = 22, Empleado = false };
            return Json(new List<Persona>() { alumno1, alumno2 }, JsonRequestBehavior.AllowGet);

        }
        */

        /*
        // redireccionar a otra pagina
        public RedirectResult Index()
        {
            return Redirect("https://google.com.mx");
        }
        */

        
        // redireccionar a otro controlador
        public RedirectToRouteResult Index()
        {
            return RedirectToAction("Contacto", "Pruebas");
        }
        
    }
}