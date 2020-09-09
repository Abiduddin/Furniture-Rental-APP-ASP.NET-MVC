using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Furniture_Rental_APP_ASP.NET_MVC.Models.BL;

namespace Furniture_Rental_APP_ASP.NET_MVC.Models.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public byte MembershipTypeId { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }
    }
}