using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furniture_Rental_APP_ASP.NET_MVC.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        [Required]
        public int SignUpFee { get; set; }
        [Required]
        public byte DurationInMonths { get; set; }
        [Required]
        public byte DiscountRate { get; set; }
    }
}