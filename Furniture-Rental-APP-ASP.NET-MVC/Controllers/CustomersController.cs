using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Furniture_Rental_APP_ASP.NET_MVC.Models.Context;

namespace Furniture_Rental_APP_ASP.NET_MVC.Controllers
{
    public class CustomersController : Controller
    {
        private ProjectDbContext _context;

        public CustomersController()
        {
            _context = new ProjectDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}