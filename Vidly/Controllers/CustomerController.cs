using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Customer()
        {
            var customer = new List<Customer>
            {
                new Customer  {Name = "Courtney Oborn" },
                new Customer  {Name = "Christopher Johnson" }
            };

            var ViewModelCustomer = new RandomMovieViewModel
            {
                Customer = customer,

            };

            return View(ViewModelCustomer);

        }
    }
}
