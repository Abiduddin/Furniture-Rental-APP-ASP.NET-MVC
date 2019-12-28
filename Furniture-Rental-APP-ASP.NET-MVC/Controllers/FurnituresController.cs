using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Furniture_Rental_APP_ASP.NET_MVC.Models.Context;

namespace Furniture_Rental_APP_ASP.NET_MVC.Controllers
{
    public class FurnituresController : Controller
    {

        private ProjectDbContext _context;

        public FurnituresController()
        {
            _context = new ProjectDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Furnitures
        public ActionResult Index()
        {
            var furnitures = _context.Furnitures.Include(c => c.Category).ToList();

            return View(furnitures);
        }

        public ActionResult Details(int id)
        {
            var furniture = _context.Furnitures.Include(c => c.Category).Include(c=>c.Brand).SingleOrDefault(c=>c.Id==id);

            if (furniture == null)
            {
                return HttpNotFound();
            }
            return View(furniture);
        }
    }
}