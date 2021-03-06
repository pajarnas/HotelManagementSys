using System.Collections.Generic;
using System.Threading.Tasks;
using SysCore.Entities;
using SysCore.Models.Requests;
using SysCore.Models.Responses;

namespace SysCore.ServiceInterfaces
{
    public interface IrService
    {
        Task<List<ServiceResponseModel>> GetAllServicesResponse();

        Task<IEnumerable<ServiceType>> GetAllServiceTypesResponse();

        Task<Service> AddService(ServiceRequest request);
    }
}