using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebPageAndDotNetDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Demo of multiple web page formats and methods.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "John Slawsky";

            return View();
        }

        public IActionResult Doggy()
        {
            ViewData["Message"] = "A special page for the dog.";

            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
