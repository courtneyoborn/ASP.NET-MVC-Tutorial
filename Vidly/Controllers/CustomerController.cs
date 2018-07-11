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
            static List<Customer> customer = new List<Customer>
            {
                new Customer  {Name = "Courtney Oborn" },
                new Customer  {Name = "Christopher Johnson" }
            };

        RandomMovieViewModel ViewModelListOfCustomers = new RandomMovieViewModel
        {
            Customer = customer,

        };
        [Route("Customer/ListOfCustomers")]
        public ActionResult ListOfCustomers()
        {
          

            return View(ViewModelListOfCustomers);

        }
    }
}
