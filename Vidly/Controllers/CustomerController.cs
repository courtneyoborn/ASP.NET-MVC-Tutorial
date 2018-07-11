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
                new Customer  {Name = "Courtney Oborn", Id = 1 },
                new Customer  {Name = "Christopher Johnson", Id = 2 }
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

        [Route("Customer/Details/{Id}")]
        public ActionResult Details(int Id)
        {
            Customer customerfound = ViewModelListOfCustomers.Customer.Find(x => x.Id == Id);
            if (customerfound == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customerfound);
            }
        }
    }
}
