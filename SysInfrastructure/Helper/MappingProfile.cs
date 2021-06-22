using System.Collections.Generic;
using System.ComponentModel;
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
            CreateMap<Room, RoomWithCustomer>()
                .ForMember(m => m.BookingDays, opt => opt.MapFrom(m => m.Customer.BookingDays))
                .ForMember(m => m.CustomerName, opt => opt.MapFrom(m => m.Customer.CName))
                .ForMember(m => m.RoomId, opt => opt.MapFrom(m => m.Id))
                .ForMember(m => m.RoomType, opt => opt.MapFrom(m => m.RoomType.RtDesc))
                .ForMember(m => m.ServiceNumbers, opt => opt.MapFrom(m => m.Services.Count))
                .ForMember(m => m.ServicesBooked, opt => opt.MapFrom(src => GetServices(src)))
                .ForMember(m => m.TotalBill, opt => opt.MapFrom(src => GetTotalBills(src)))
                .ForMember(m => m.CheckInDates, opt => opt.MapFrom(m => m.Customer.Checkin));
                
            CreateMap<Room, RoomResponseModel>().ForMember(m=>m.Price,opt=>opt.MapFrom(src=>src.RoomType.Rent))
                .ForMember(m=>m.RoomType,opt=>opt.MapFrom(src=>src.RoomType.RtDesc))
                .ForMember(m=>m.RoomTypeId,opt=>opt.MapFrom(src=>src.RoomType.Id));
           
            CreateMap<RoomType, AvailableRoomTypeResponseModel>()
                .ForMember(m=>m.Price,opt=>opt.MapFrom(src=>src.Rent))
                .ForMember(m=>m.RoomType,opt=>opt.MapFrom(src=>src.RtDesc))
                .ForMember(m=>m.Availables,opt=>opt.MapFrom(src=>src.Rooms.Count))
                .ForMember(m=>m.RoomTypeId,opt=>opt.MapFrom(src=>src.Id));
        }

        private List<ServiceResponseModel> GetServices(Room room)
        {
            var serviceResponseModel = new List<ServiceResponseModel>();
      
            foreach (var service in room.Services)
                serviceResponseModel.Add(new ServiceResponseModel
                {
                    ServiceDate = service.ServiceDate,
                    ServiceDesc = service.ServiceType.SDesc,
                    ServiceId = service.Id,
                    ServicePrice = service.ServiceType.Amount
                     
                });

            return  serviceResponseModel;
        }
        
        private decimal? GetTotalBills(Room room)
        {

            decimal? d = 0;
            foreach (var service in room.Services)
            {
                d += service.ServiceType.Amount;
            }

            d += room.RoomType.Rent;
            return  d;
        }
    }
}