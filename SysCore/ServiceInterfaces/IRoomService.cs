using System.Collections.Generic;
using System.Threading.Tasks;
using SysCore.Models.Responses;

namespace SysCore.ServiceInterfaces
{
    public interface IRoomService
    {
       
        Task<List<RoomResponseModel>> GetRoomResponse();
        Task<List<AvailableRoomTypeResponseModel>> GetAvailableRoomTypes();
        Task<List<RoomResponseModel>> GetAvaiableRooms();
        Task<List<RoomResponseModel>> GetAvaiableRoomsByType(int id);
        Task<RoomResponseModel> GetById(int id);

        Task<IEnumerable<RoomWithCustomer>> GetBookedRooms();
        Task<RoomResponseModel> GetRandomAvailable(int id);


    }
}