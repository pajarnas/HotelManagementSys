using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SysCore.Models.Requests;
using SysCore.ServiceInterfaces;

namespace HotelManagementSys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomServiceController : ControllerBase
    {
        private readonly IrService _rService;
        
        public RoomServiceController(IrService rService)
        {
            _rService = rService;
        }
      
        //Get api/customers
        [HttpGet("roomservices")]
        public async Task<IActionResult> GetServices()
        {
            var customerModels = await _rService.GetAllServicesResponse();
            //TODO add authorize, add Exception
            return Ok(customerModels);
        }
        
        //Get api/customers
        [HttpGet("servicetypes")]
        public async Task<IActionResult> GetServiceTypes()
        {
            var customerModels = await _rService.GetAllServiceTypesResponse();
            //TODO add authorize, add Exception
            return Ok(customerModels);
        }
        
       
    }
}