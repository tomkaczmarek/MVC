using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            //Movie movie = new Movie() { Name = "Shrek"};
            //List<Customers> customers = new List<Customers>
            //{
            //    new Customers {Name = "Customers1"},
            //    new Customers {Name = "Customers2"}
            //};

            //RandomMovieViewModel viewModel = new RandomMovieViewModel
            //{
            //    Movie = movie,
            //    Customers = customers
            //};

            List<Movie> movies = new List<Movie>
            {
                new Movie {Name = "Shrek"},
                new Movie {Name = "Kiler"}
            };

            RandomMovieViewModel movieView = new RandomMovieViewModel
            {
                Movies = movies
            };

            return View(movieView);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrEmpty((sortBy)))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content((year + "/" + month));
        }
    }
}