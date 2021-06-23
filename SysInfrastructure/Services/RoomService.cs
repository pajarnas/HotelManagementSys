using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SysCore.Entities;
using SysCore.Helpers;
using SysCore.Models.Responses;
using SysCore.ServiceInterfaces;
using SysCore.RepositoryInterfaces;
using SysCore.RepositoryInterfaces.BaseInterfaces;
using SysInfrastructure.Repositories;

namespace SysInfrastructure.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepo _roomRepo;
        private readonly IMapper _mapper;
        private readonly IRelationRepo<RoomType> _roomTypeCrudRepo;
        private readonly IRelationRepo<Customer> _customerRepo;
        public RoomService(IRoomRepo roomRepo,IMapper mapper,IRelationRepo<RoomType> roomTypeCrudRepo,IRelationRepo<Customer> customerRepo)
        {
            _roomRepo = roomRepo;
            _mapper = mapper;
            _roomTypeCrudRepo = roomTypeCrudRepo;
            _customerRepo = customerRepo;
        }
  

        public async Task<List<RoomResponseModel>> GetRoomResponse()
        {
        
            var entities = await _roomRepo.ListWithIncludesAsync(p =>  p.Include(m => m.RoomType),null);
            var models = _mapper.Map<List<RoomResponseModel>>(entities);
            return  models;
        }
        
        public async Task<List<AvailableRoomTypeResponseModel>> GetAvailableRoomTypes()
        {
            var entities = await _roomTypeCrudRepo.ListWithIncludesAsync(m=>m.Include(m=>m.Rooms.Where(m=>m.Status==false)),null);
           
            var models = _mapper.Map<List<AvailableRoomTypeResponseModel>>(entities);
            return models;
        }


        public async Task<List<RoomResponseModel>> GetAvaiableRooms()
        {
            var entities = await _roomRepo.ListWithIncludesAsync(p =>  p.Include(m => m.RoomType),m => m.Status == false);
            var models = _mapper.Map<List<RoomResponseModel>>(entities);
            return models;
        }
        //Booked = True
        
        public async Task<IEnumerable<RoomWithCustomer>> GetBookedRooms()
        {
            //var entities = await _roomRepo.ListWithIncludesAsync(p =>  (p.Include(m => m.Customer)).Include(m=>m.RoomType),m => m.Status == false);
            var customers = await _customerRepo.ListWithIncludesAsync(m => m.Include(m => m.Room).ThenInclude(m=>m.RoomType),m=>m.Room.Status==true);

            var rooms = await _roomRepo.ListWithIncludesAsync(m => m.Include(m => m.Services).ThenInclude(m=>m.ServiceType),m=>m.Status==true);

            var c = customers.Select(m=>m.Room).Union(rooms);

            var models = _mapper.Map<IEnumerable<RoomWithCustomer>>(c);
            
            /*
            var models2 = customers.Select((m) => new RoomWithCustomer
            {
                CheckInDates = m.Checkin,
                CustomerName = m.CName,
                RoomType = m.Room.RoomType.RtDesc,
                RoomId = m.Room.Id,
                TotalBill = GetTotalBills(m.Room),
                BookingDays = m.BookingDays,
                ServicesBooked = GetServices(m.Room),
                ServiceNumbers = m.Room.Services.Count,
                
            }).ToList();
            */
            
        
            return models;
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

        public async Task<List<RoomResponseModel>> GetAvaiableRoomsByType(int id)
        {
            var entities = await _roomRepo.ListWithIncludesAsync(p =>  p.Include(m => m.RoomType),m => m.Status == false);
            var models = _mapper.Map<List<RoomResponseModel>>(entities.Where(m=>m.RoomType.Id==id));
            return models;
        }

        public async Task<RoomResponseModel> GetById(int id)
        {
            var room = await _roomRepo.GetByIdWithIncludesAsync(include:m=>m.Include(m=>m.RoomType),filter:m=>m.Id==id);
            var m = _mapper.Map<RoomResponseModel>(room);
            return m;
        }

        public async Task<RoomResponseModel> GetRandomAvailable(int id)
        {
            var roomResponseModels = await this.GetAvaiableRoomsByType(id);
            if (roomResponseModels == null) return null;
            var r = roomResponseModels.FirstOrDefault();
            return r;
        }

        public async Task<RoomWithCustomer> GetOneRoomWituCustomerById(int id)
        {
            var w = await GetBookedRooms();
            return w.Where(m => m.RoomId == id).SingleOrDefault();
            
        }

        public async Task<PaginatedList<RoomWithCustomer>> GetPagintedRoom(int index,int size)
        {
            var src = await GetBookedRooms();
            var w = new PaginatedList<RoomWithCustomer>(items:src.ToList(),src.Count(),index,size);
            return w;
        }
    }
}