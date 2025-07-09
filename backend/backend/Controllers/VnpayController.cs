using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("Vnpay")]
    [ApiController]
    public class VnpayController : ControllerBase
    {
        [HttpGet("IPN")]
        public IActionResult IPN()
        {
            Console.WriteLine(HttpContext.Request.Query);
            return Ok(HttpContext.Response.Body);
        }

        [HttpPost]

        public IActionResult POST() { return Ok(); }
    }
}
