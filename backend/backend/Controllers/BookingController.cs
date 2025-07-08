using backend.Interface.BookingInterface;
using backend.ModelDTO.Customer.OrderRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingServices _services;

        public BookingController(IBookingServices services)
        {
            _services = services;
        }

        [HttpPost("Booking")]
        public async Task<IActionResult> booking(OrderRequestDTO dtos)
        {
            var getBookingstatus = await _services.booking(dtos , HttpContext);
            if (getBookingstatus.Equals("Lỗi"))
            {
                return BadRequest();
            }
            return Ok(getBookingstatus);
        }
    }
}
