using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SysCore.Entities;
using SysCore.Models.Responses;
using SysCore.RepositoryInterfaces.BaseInterfaces;
using SysCore.ServiceInterfaces;

namespace SysInfrastructure.Services
{
    public class RsService:IrService
    {
        private readonly IRelationRepo<Service> _roomServiceRepo;
        private readonly IAsyncCRUDRepo<ServiceType> _serviceTypeRepo;
        private readonly IMapper _mapper;
        public RsService(IRelationRepo<Service> roomServiceRepo,IMapper mapper,IAsyncCRUDRepo<ServiceType> serviceTypeRepo)
        {
            _roomServiceRepo = roomServiceRepo;
            _serviceTypeRepo = serviceTypeRepo;
            _mapper = mapper;
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
    }
}