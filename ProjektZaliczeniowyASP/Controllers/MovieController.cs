using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjektZaliczeniowyASP.Models;

namespace ProjektZaliczeniowyASP.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "nanananna"};

            return View(movie);
        }
    }
}