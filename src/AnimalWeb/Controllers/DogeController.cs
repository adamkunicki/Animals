using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Diagnostics;

namespace AnimalWeb.Controllers
{
    public class DogeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
