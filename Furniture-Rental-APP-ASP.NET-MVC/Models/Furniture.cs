using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furniture_Rental_APP_ASP.NET_MVC.Models
{
    public class Furniture
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public Brand Brand { get; set; }


        [Required]
        public int BrandId { get; set; }

        public Category Category { get; set; }


        [Required]
        public int CategoryId { get; set; }

        public string Material { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        [Required]
        public int Stock { get; set; }

        //length height depth

    }
}