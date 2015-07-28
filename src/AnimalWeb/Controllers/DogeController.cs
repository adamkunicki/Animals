using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Diagnostics;
using Animal.Db;

namespace AnimalWeb.Controllers
{
    public class DogeController : Controller
    {
        private readonly AnimalModel context;

        public DogeController(AnimalModel context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var model = this.context.Dogs.ToArray();

            return View(model);
        }
    }
}
