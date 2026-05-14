using IDGS904ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904ASP.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contacto()
        {
            ViewBag.Nombre = "Karla";
            ViewBag.Apellido = "Martinez";
            ViewData["Materia"] = "DWI";
            return View();
        }

        public ActionResult Empleado()
        {
            var persona = new Persona()
            {
                Nombre = "Karla",
                Edad = 21,
                Empleado = true,
                Nacimiento = new DateTime(2004, 11, 21)
            };
            ViewBag.Propiedad = persona;
            return View();
        }
    }
}