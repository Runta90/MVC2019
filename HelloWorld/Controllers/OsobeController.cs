using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class OsobeController : Controller
    {
        // GET: Osobe
        public ViewResult PopuniOsobu()
        {
            return View();
        }

        //POSt: Osoba/PopuniOsobu
        [HttpPost]
        public ActionResult PopuniOsobu(Osoba osoba)
        {
            return View(osoba);
        }

    }
}