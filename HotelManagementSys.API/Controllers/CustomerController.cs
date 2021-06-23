using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SysCore.Models.Requests;
using SysCore.ServiceInterfaces;

namespace HotelManagementSys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
      
        //Get api/customers
        [HttpGet("customers")]
        public async Task<IActionResult> Customers()
        {
            var customerModels = await _customerService.GetCustomerResponse();
            //TODO add authorize, add Exception
            return Ok(customerModels);
        }
        
        
        [HttpGet("details")]
        public async Task<IActionResult> Details()
        {
            var customerModels = await _customerService.GetCustomerDetailResponse();
            //TODO add authorize, add Exception
            return Ok(customerModels);
        }
        
        [HttpPost("book")]
        public async Task<IActionResult> Book([FromBody]BookRequest bookRequest)
        {
            await _customerService.BookRoomForUser(bookRequest);
            return Ok();
        }
        
        
        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _customerService.DeleteBook(id);
            return Ok();
        }
    }
}