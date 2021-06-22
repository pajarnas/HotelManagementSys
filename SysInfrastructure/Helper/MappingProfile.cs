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
            
           

            CreateMap<Room, RoomResponseModel>().ForMember(m=>m.Price,opt=>opt.MapFrom(src=>src.RoomType.Rent))
                .ForMember(m=>m.RoomType,opt=>opt.MapFrom(src=>src.RoomType.RtDesc))
                .ForMember(m=>m.RoomTypeId,opt=>opt.MapFrom(src=>src.RoomType.Id));
           
            CreateMap<RoomType, AvailableRoomTypeResponseModel>()
                .ForMember(m=>m.Price,opt=>opt.MapFrom(src=>src.Rent))
                .ForMember(m=>m.RoomType,opt=>opt.MapFrom(src=>src.RtDesc))
                .ForMember(m=>m.Availables,opt=>opt.MapFrom(src=>src.Rooms.Count))
                .ForMember(m=>m.RoomTypeId,opt=>opt.MapFrom(src=>src.Id));
        }
        
    }
}