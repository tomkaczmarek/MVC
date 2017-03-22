using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        private IEnumerable<Customers> GetCustomers()
        {
            return new List<Customers>()
            {
                new Customers {Name = "Jon", Id = 1},
                new Customers {Name = "Robert", Id = 2}
            };

        }


        // GET: Customer
        public ActionResult Random(int id)
        {
            var customers = GetCustomers().SingleOrDefault(c => c.Id == id);

            return View(customers);
        }
    }
}