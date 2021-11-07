using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //HTTP Get /HelloWorld
        public IActionResult Index()
        {
            return View(); //This calles the View method, which uses a view template to generate a view response
        }

        //HTTP Get /HelloWorld/Welcome
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        //Running this and editing the localhost to localhost/HelloWorld would load a page with just the return of Index.

        //MapControllerRoute  contains the routing format in Startup.cs. 
    }
}
