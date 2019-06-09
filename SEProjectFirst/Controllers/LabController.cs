using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEProjectFirst.Controllers
{
    public class LabController : Controller
    {
        // GET: Lab
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lab(string name, int times)
        {
            ViewBag.times = times;
            ViewBag.name = name;
            return View();
        }
    }
}