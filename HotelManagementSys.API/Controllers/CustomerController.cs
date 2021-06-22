using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
 
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
    }
}