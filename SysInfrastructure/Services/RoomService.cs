using System.Collections.Generic;

using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SysCore.Entities;
using SysCore.Models.Responses;
using SysCore.ServiceInterfaces;
using SysCore.RepositoryInterfaces;
namespace SysInfrastructure.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepo _roomRepo;
        private readonly IMapper _mapper;
        public RoomService(IRoomRepo roomRepo,IMapper mapper)
        {
            _roomRepo = roomRepo;
            _mapper = mapper;
        }
        public Task<List<RoomDetailResponseModel>> GetRoomDetailResponse()
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<RoomResponseModel>> GetRoomResponse()
        {
        
            var entities = await _roomRepo.ListWithIncludesAsync(p =>  p.Include(m => m.RoomType),null);
            var models = _mapper.Map<List<RoomResponseModel>>(entities);
            return  models;
        }
        
        
    }
}