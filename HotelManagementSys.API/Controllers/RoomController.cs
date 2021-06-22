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
    }
}