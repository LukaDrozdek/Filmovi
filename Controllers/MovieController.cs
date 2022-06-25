using Filmovi.Models;
using Filmovi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filmovi.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Lord of the rings" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Kupac01"},
                new Customer {Name = "Kupac02"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
    }
}