using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Furniture_Rental_APP_ASP.NET_MVC.Models;
using Furniture_Rental_APP_ASP.NET_MVC.Models.Context;
using Furniture_Rental_APP_ASP.NET_MVC.Models.ViewModels;

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

            var viewModel = new FurnitureFormViewModel
            {
                Furniture = furniture,
                Brands = _context.Brands.ToList(),
                Categories = _context.Categories.ToList()

            };
            return View("FurnitureForm",viewModel);
        }

        public ActionResult New()
        {
            var viewModel = new FurnitureFormViewModel
            {
                Brands = _context.Brands.ToList(),
                Categories = _context.Categories.ToList()
                
            };

            return View("FurnitureForm", viewModel);
        }

        public ActionResult Save(Furniture furniture)
        {
            if (!ModelState.IsValid)
            {

                var viewModel = new FurnitureFormViewModel
                {
                    Furniture = furniture,
                    Brands = _context.Brands.ToList(),
                    Categories = _context.Categories.ToList()

                };

                return View("FurnitureForm", viewModel);
            }

            if (furniture.Id == 0)
            {
                _context.Furnitures.Add(furniture);

            }
            else
            {
                var furnitureInDb = _context.Furnitures.Single(x => x.Id == furniture.Id);
                furnitureInDb.Name = furniture.Name;
                furnitureInDb.Model = furniture.Model;
                furnitureInDb.Color = furniture.Color;
                furnitureInDb.Material = furniture.Material;
                furnitureInDb.Stock = furniture.Stock;
                furnitureInDb.BrandId = furniture.BrandId;
                furnitureInDb.CategoryId = furniture.CategoryId;
            }


            _context.SaveChanges();

            return RedirectToAction("Index", "Furnitures");
        }
    }
}