using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Furniture_Rental_APP_ASP.NET_MVC.Models
{
    public class Furniture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public string Type { get; set; }

        public string Material { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        //length height depth

    }
}