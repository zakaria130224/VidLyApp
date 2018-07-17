using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidLy.Controllers;
using VidLy.Models;

namespace VidLy.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/random
        //public ActionResult Random()
        //{
        //   var movie= new Movie(){ID=01, Name ="3 ediots"};
        //    //return View(movie);
        //    //return new ViewResult(movie);
        //    //return HttpNotFound();
        //    //return Content("");
        //    //return Redirect("~/Home/Index");
        //    return RedirectToAction("Index", "Home", new { page = 1 });
        //}
        //public ActionResult Edit(int MovieId)
        //{
        //    return Content("ID=" + MovieId);
        //}
        //public ActionResult Index(int? page, string name)
        //{
        //    if (!page.HasValue)
        //        page = 1;

        //    if (String.IsNullOrWhiteSpace(name))
        //        name = "Zakaria";

        //    return Content("page=" + page + " name=" + name);
        //}
        public ViewResult Index()
        {
            var customers = GetMovies();

            return View("ViewAllMovies", customers);
        }

        //public ActionResult Details(int id)
        //{
        //    var movies = GetMovies().SingleOrDefault(c => c.Id == id);

        //    if (movies == null)
        //        return HttpNotFound();

        //    return View("CustomerDetails", movies);
        //}

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
                {
                    new Movie { Id = 1, Name = "Piku" },
                    new Movie { Id = 2, Name = "Shanju" }
                };
        }
    }
}