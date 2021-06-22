using System.Collections.Generic;
using System.Threading.Tasks;
using SysCore.Models.Responses;

namespace SysCore.ServiceInterfaces
{
    public interface IRoomService
    {
        Task<List<RoomDetailResponseModel>> GetRoomDetailResponse();
        
        Task<List<RoomResponseModel>> GetRoomResponse();
        
         
    }
}