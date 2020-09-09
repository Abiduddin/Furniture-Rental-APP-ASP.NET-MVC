using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Furniture_Rental_APP_ASP.NET_MVC.Models;
using Furniture_Rental_APP_ASP.NET_MVC.Models.Dtos;

namespace Furniture_Rental_APP_ASP.NET_MVC.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}