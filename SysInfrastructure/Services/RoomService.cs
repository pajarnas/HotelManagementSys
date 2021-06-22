using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SysCore.Entities;
using SysCore.Models.Responses;
using SysCore.ServiceInterfaces;
using SysCore.RepositoryInterfaces;
using SysCore.RepositoryInterfaces.BaseInterfaces;

namespace SysInfrastructure.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepo _roomRepo;
        private readonly IMapper _mapper;
        private readonly IRelationRepo<RoomType> _roomTypeCrudRepo;
        public RoomService(IRoomRepo roomRepo,IMapper mapper,IRelationRepo<RoomType> roomTypeCrudRepo)
        {
            _roomRepo = roomRepo;
            _mapper = mapper;
            _roomTypeCrudRepo = roomTypeCrudRepo;
        }
  

        public async Task<List<RoomResponseModel>> GetRoomResponse()
        {
        
            var entities = await _roomRepo.ListWithIncludesAsync(p =>  p.Include(m => m.RoomType),null);
            var models = _mapper.Map<List<RoomResponseModel>>(entities);
            return  models;
        }
        
        public async Task<List<AvailableRoomTypeResponseModel>> GetAvailableRoomTypes()
        {
            var entities = await _roomTypeCrudRepo.ListWithIncludesAsync(m=>m.Include(m=>m.Rooms.Where(m=>m.Status==true)),null);
           
            var models = _mapper.Map<List<AvailableRoomTypeResponseModel>>(entities);
            return models;
        }


        public async Task<List<RoomResponseModel>> GetAvaiableRooms()
        {
            var entities = await _roomRepo.ListWithIncludesAsync(p =>  p.Include(m => m.RoomType),m => m.Status == true);
            var models = _mapper.Map<List<RoomResponseModel>>(entities);
            return models;
        }

        public async Task<List<RoomResponseModel>> GetAvaiableRoomsByType(int id)
        {
            var entities = await _roomRepo.ListWithIncludesAsync(p =>  p.Include(m => m.RoomType),m => m.Status == true);
            var models = _mapper.Map<List<RoomResponseModel>>(entities.Where(m=>m.RoomType.Id==id));
            return models;
        }
        
        
    }
}