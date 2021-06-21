using System.Collections.Generic;
using System.Threading.Tasks;
using SysCore.Models.Responses;

namespace SysCore.ServiceInterfaces
{
    public interface ICustomerService
    {
        Task<List<CustomerDetailResponseModel>> GetCustomerDetailResponse();
        
        Task<List<CustomerResponseModel>> GetCustomerResponse();
    }
}