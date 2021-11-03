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
        public string Index()
        {
            return "This is my default action...";
        }

        //HTTP Get /HelloWorld/Welcome
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        //Running this and editing the localhost to localhost/HelloWorld would load a page with just the return of Index.
    }
}
