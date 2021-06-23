using System.Collections.Generic;
using System.Threading.Tasks;
using SysCore.Models.Requests;
using SysCore.Models.Responses;

namespace SysCore.ServiceInterfaces
{
    public interface ICustomerService
    {
        Task<List<CustomerDetailResponseModel>> GetCustomerDetailResponse();
        
        Task<List<CustomerResponseModel>> GetCustomerResponse();

        Task<bool> BookRoomForUser(BookRequest bookRequest);
        Task<bool> DeleteBook(int id);
    }
}