using backend.Enum;
using backend.Interface.FoodInterface;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FoodController : ControllerBase
{
    // Khoi tao doi tuong
    private readonly IFoodService _foodService;

    public FoodController(IFoodService foodService)
    {
        _foodService = foodService;
    }

    [HttpGet("GetFoodInformation")]
    public IActionResult GetFoodInformation()
    {
        var getFood = _foodService.getFullListOfFoods();
        if (getFood.Status.Equals(GenericStatusEnum.Failure.ToString()))
        {
            return BadRequest(getFood);
        }
        return Ok(getFood);
    }
    
}