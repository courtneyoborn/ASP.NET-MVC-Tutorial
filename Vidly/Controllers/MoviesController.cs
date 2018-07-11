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
    public class MovieController : Controller
    {
       static List<Movie> movie = new List<Movie>
            {
                new Movie  { Name = "Shrek", Id = 1},
                new Movie  { Name = "Wall-e", Id = 2}
            };

        RandomMovieViewModel viewModelMovies = new RandomMovieViewModel
        {
            Movie = movie,
        };

        [Route("Movies/MovieTitles")]

        public ActionResult Movies()
        {

              return View(viewModelMovies);
        }

        
        //public ActionResult MovieTitles()  
        //{
        //    return View();
        //}
    }
}