using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesandCustomerController : Controller
    {
        public ActionResult Random()
        {
            var movie = new List<Movie>
            {
                new Movie  { Name = "Shrek" },
                new Movie  { Name = "Wall-e"}
            };
            var customer = new List<Customer>
            {
                new Customer  {Name = "Courtney Oborn" },
                new Customer  {Name = "Christopher Johnson" }
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customer
            };

              return View(ViewModel);
        }
        
    }
}