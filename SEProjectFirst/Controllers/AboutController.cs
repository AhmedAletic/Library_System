using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEProjectFirst.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string name, int times)
        {
            ViewBag.times = times;
            ViewBag.name = name;
            return View();
        }
    }
}