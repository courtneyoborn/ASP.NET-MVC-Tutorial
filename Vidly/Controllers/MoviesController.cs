﻿using Microsoft.Ajax.Utilities;
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
            var movie = new Movie() { Name = "Shrek!" };
            var customer = new List<Customer>
            {
                new Customer {Name = "Customer1" },
                new Customer {Name = "Customer2" }
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customer
            };

           // ViewData["Movie"] = movie; different way to pass data to a view
           // View.Bag.Movie = movie; another way to pass data to a view
              return View(ViewModel);
            // return Content("Hello World!");
            // return HttpNotFound();
            //  return new EmptyResult();
           // return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name" });
        }
        
        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}
        //public ActionResult Index(int? pageIndex, string SortBy)
        //{
        //    if (pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (string.IsNullOrWhiteSpace(SortBy))
        //        SortBy = "Name";

        //    return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, SortBy));
        //}
        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12}")]
        //public ActionResult ByReleaseYear(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}