using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS904ASP.Models;

namespace IDGS904ASP.Controllers
{
    public class CinepolisController : Controller
    {
        // GET: Cinepolis
        public ActionResult Index()
        {
            return View(new Cinepolis());
        }

        [HttpPost]
        public ActionResult Index(Cinepolis cinepolis)
        {
            cinepolis.CalcularPago();
            return View(cinepolis); 
        }
    }
}