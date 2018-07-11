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

        [Route("Movie/MovieTitles")]

        public ActionResult MovieTitles()
        {

              return View(viewModelMovies);
        }

        [Route("Movie/Details/{Id}")]

        public ActionResult Details(int Id)
        {
            Movie movieFound = viewModelMovies.Movie.Find(x => x.Id == Id);
            if(movieFound == null)
            {
              return  HttpNotFound();
            }
            else
            {
                return View(movieFound);
            }
            
        }


    }
}