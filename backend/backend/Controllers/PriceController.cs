using backend.Enum;
using backend.Interface.PriceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PriceController(IPriceService priceService) : ControllerBase
{
    private readonly IPriceService _priceService = priceService;

    [HttpGet("getPrices/{movieVisualId}")]
    public IActionResult GetPrices(string movieVisualId)
    {
        var getStatus = _priceService.GetListPrice(movieVisualId);
        if (getStatus.Status.Equals(GenericStatusEnum.Failure.ToString()))
        {
            return BadRequest(getStatus);
        }
        return Ok(getStatus);
    }
}