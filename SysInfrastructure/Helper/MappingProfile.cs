using System.Collections.Generic;
using System.Linq;
using SysCore.Entities;
using SysCore.Models.Responses;
using SysCore.Models.Requests;
using AutoMapper;

namespace Infrastructure.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Customer, CustomerResponseModel>();

            CreateMap<Customer, CustomerDetailResponseModel>();

            CreateMap<RoomType, RoomTypesResponseModel>();



        }
        
   


    }
}