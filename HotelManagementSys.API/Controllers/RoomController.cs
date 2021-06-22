using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
 
using SysCore.ServiceInterfaces;

namespace HotelManagementSys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }
      
        //Get api/rooms
        [HttpGet("rooms")]
        public async Task<IActionResult> Rooms()
        {
            var roomModels = await _roomService.GetRoomResponse();
            //TODO add authorize, add Exception
            return Ok(roomModels);
        }
        
        //Get api/rooms/bytypes
        [HttpGet("rooms/availableRoomTypes")]
        public async Task<IActionResult> GetAvailableRoomTypes()
        {
            var roomModels = await _roomService.GetAvailableRoomTypes();
            
            return Ok(roomModels);
        }
        
        [HttpGet("rooms/availables")]
        public async Task<IActionResult> GetAvailableRooms()
        {
            var roomModels = await _roomService.GetAvaiableRooms();
            
            return Ok(roomModels);
        }
        
        
        //Get api/rooms/bytypes
        [HttpGet("rooms/availables/{id:int}")]
        public async Task<IActionResult> RoomsOrderByPrice([FromRoute] int id)
        {
            
            var roomModels = await _roomService.GetAvaiableRoomsByType(id);
            
            return Ok(roomModels);
        }
    }
}