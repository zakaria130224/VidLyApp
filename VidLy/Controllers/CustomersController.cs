using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidLy.Models;

namespace VidLy.Controllers
{
   
        public class CustomersController : Controller
        {
            private VidlyAppDbContext _context;

        public CustomersController()
        {
            _context = new VidlyAppDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
            {
                var customers = _context.Customers.Include(c=>c.membershipType);

                return View("ViewAllCustomer",customers);
            }

            public ActionResult Details(int id)
            {
                var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

                if (customer == null)
                    return HttpNotFound();

                return View("CustomerDetails", customer);
            }

            //private IEnumerable<Customer> GetCustomers()
            //{
            //    return new List<Customer>
            //    {
            //        new Customer { Id = 1, Name = "John Smith" },
            //        new Customer { Id = 2, Name = "Mary Williams" }
            //    };
            //}
        }
    
}