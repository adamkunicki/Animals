using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Diagnostics;
using Animal.Db;

namespace AnimalWeb.Controllers
{
    public class HomeController : Controller
    {
        AnimalModel _model;
        public HomeController(AnimalModel model)
        {
            _model = model;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            var d = _model.Dogs.FirstOrDefault();

            return View(d);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            Console.WriteLine("Contact to cosole...");
            Trace.TraceInformation("Contact info trace");
            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
