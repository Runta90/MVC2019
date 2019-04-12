using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.Models;
using System.Data.Entity;

namespace Webshop.Controllers
{
    public class WebshopController : Controller
    {
        private WebShopEntities db = new WebShopEntities();
        // GET: Webshop
        public ActionResult Index()
        {
            var proizvodi = db.Proizvodis.Include(p => p.MjereProizvoda );
            return View(proizvodi.ToList());
        }
    }
}