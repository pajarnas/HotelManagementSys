using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SysCore.Entities;
using SysCore.Models.Requests;
using SysCore.Models.Responses;
using SysCore.RepositoryInterfaces;
using SysCore.RepositoryInterfaces.BaseInterfaces;
using SysCore.ServiceInterfaces;

namespace SysInfrastructure.Services
{
    public class RsService:IrService
    {
        private readonly IRelationRepo<Service> _roomServiceRepo;
        private readonly IAsyncCRUDRepo<Service> _roomCrudServiceRepo;
        private readonly IAsyncCRUDRepo<ServiceType> _serviceTypeRepo;
        private readonly IRoomRepo _roomRepo;
        private readonly IMapper _mapper;
        public RsService(IRelationRepo<Service> roomServiceRepo,IMapper mapper,IAsyncCRUDRepo<Service> roomCrudServiceRepo,IAsyncCRUDRepo<ServiceType> serviceTypeRepo,IRoomRepo roomRepo)
        {
            _roomServiceRepo = roomServiceRepo;
            _serviceTypeRepo = serviceTypeRepo;
            _roomCrudServiceRepo = roomCrudServiceRepo;
            _mapper = mapper;
            _roomRepo = roomRepo;
        }
        
        public async Task<List<ServiceResponseModel>> GetAllServicesResponse()
        {
            var entities = await  _roomServiceRepo.ListWithIncludesAsync(m => m.Include(m => m.ServiceType),null);
            entities.GroupBy(m => m.ServiceType,(k,c)=>new Service()
            {
                    Id = k.Services.First().Id,
                    ServiceDate = k.Services.First().ServiceDate,
                    ServiceType = k,
                    ServiceTypeId = k.Id
            });
            var models = _mapper.Map<List<ServiceResponseModel>>(entities);
            return models;
        }
        
        public async Task<IEnumerable<ServiceType>> GetAllServiceTypesResponse()
        {

            return await _serviceTypeRepo.ListAllAsync();

        }

        public async Task<Service> AddService(ServiceRequest request)
        {
           
                        var service = new Service
                        {
                            RoomId = request.roomId.Value,
                            ServiceTypeId = request.serviceTypeId.Value,
                            ServiceDate = DateTime.Now,

                            ServiceType = await _serviceTypeRepo.GetByIdAsync(request.serviceTypeId.Value),
                            Room = await _roomRepo.GetByIdAsync(request.roomId.Value)
                        };
                        
                        
                        return  await _roomCrudServiceRepo.AddAsync(service);
        }
    }
}