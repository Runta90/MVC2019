using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class KontekstController : Controller
    {
        // GET: Kontekst
        public string Index()
        {
            string poruka = "Danas je: " + DateTime.Now.ToLongDateString();
            return poruka;
            //return View();
        }


    }
}