using backend.Enum;
using backend.Interface.RoomInferface;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CinemaRoomController(IRoomService roomService) : ControllerBase
{
    private readonly IRoomService _roomService = roomService;
    
    [HttpGet("GetCinemaRoomInfo")]
    public IActionResult GetCinemaRoomInfo(string movieID , DateTime scheduleDate ,  string HourId , string movieVisualID)
    {
        var getCinemaRoomInfo = _roomService.getRoomInfo(movieID,scheduleDate,HourId,movieVisualID);
        if(getCinemaRoomInfo.Status.Equals(GenericStatusEnum.Failure.ToString()))
        {
            return BadRequest(getCinemaRoomInfo);   
        }
        return Ok(getCinemaRoomInfo);
    }
    
}