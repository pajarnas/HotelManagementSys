using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using SysCore.Entities;
using SysCore.Models.Responses;
using SysCore.ServiceInterfaces;
using SysCore.RepositoryInterfaces;
namespace SysInfrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepo customerRepo,IMapper mapper)
        {
            _customerRepo = customerRepo;
            _mapper = mapper;
        }
        public Task<List<CustomerDetailResponseModel>> GetCustomerDetailResponse()
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<CustomerResponseModel>> GetCustomerResponse()
        {
            var entities = await _customerRepo.ListAllAsync();
            var models = _mapper.Map<List<CustomerResponseModel>>(entities);
            return  models;
        }
    }
}