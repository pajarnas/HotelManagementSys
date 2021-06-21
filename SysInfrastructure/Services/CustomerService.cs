using System.Collections.Generic;
using System.Threading.Tasks;
using SysCore.Models.Responses;
using SysCore.ServiceInterfaces;

namespace SysInfrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        public Task<List<CustomerDetailResponseModel>> GetCustomerDetailResponse()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<CustomerResponseModel>> GetCustomerResponse()
        {
            throw new System.NotImplementedException();
        }
    }
}