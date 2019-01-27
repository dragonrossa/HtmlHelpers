using HtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.Controllers
{
    public class HtmlHelpersController : Controller
    {
        // GET: HtmlHelpers
        public ViewResult OsnovniHelperi()
        {
            return View();
        }

        private string[] mjesta = new string[]{"Split", "Rijeka", "Zagreb" };

        public ViewResult FormHelper()
        {
            ViewBag.Mjesta = mjesta;

            return View(new Osoba());
        }

        [HttpPost]

        public ViewResult FormHelper(Osoba osoba)
        {
            ViewBag.Mjesta = mjesta;
            ViewBag.Poruka = "Podaci uneseni!";
            return View(osoba);
        }

        public ViewResult StrongTypedHelper()
        {
            ViewBag.Mjesta = mjesta;
            return View(new Osoba());
        }


        [HttpPost]

        public ViewResult StrongTypedHelper(Osoba osoba)
        {
            ViewBag.Mjesta = mjesta;
            ViewBag.Poruka = "Podaci uneseni!";
            return View(osoba);
        }
    }
}