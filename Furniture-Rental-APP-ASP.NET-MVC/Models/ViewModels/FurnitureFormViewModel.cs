using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Furniture_Rental_APP_ASP.NET_MVC.Models.ViewModels
{
    public class FurnitureFormViewModel
    {
        public Furniture Furniture { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Brand> Brands { get; set; }

    }
}