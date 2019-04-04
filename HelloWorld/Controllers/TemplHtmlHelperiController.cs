using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class TemplHtmlHelperiController : Controller
    {
        // GET: TemplHtmlHelperi
        public ViewResult HtmlEditorView()
        {
            return View(new OsobaTemp1());
        }

        [HttpPost]
        public ViewResult HtmlEditorView(OsobaTemp1 osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }

        public ViewResult EditorModelView()
        {
            return View(new OsobaTemp1());
        }

        [HttpPost]
        public ViewResult EditorModelView(OsobaTemp1 osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
    }
}