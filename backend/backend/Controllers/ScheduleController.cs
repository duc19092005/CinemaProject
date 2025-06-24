using backend.Interface.Schedule;
using backend.ModelDTO.ScheduleDTO.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleServices scheduleServices;

        public ScheduleController(IScheduleServices scheduleServices)
        {
            this.scheduleServices = scheduleServices;
        }

        [HttpPost("addSchedule")]
        public async Task<IActionResult> addSchedule(ScheduleRequestDTO scheduleRequestDTO)
        {
            var status = await scheduleServices.add(scheduleRequestDTO);
            if (status)
            {
                return Ok(new {message = "Thêm thành công"});
            }
            return BadRequest(new {message = "Thêm thất bại"});
        }

        [HttpPatch("removeSchedule")]
        public async Task<IActionResult> removeSchedule(string id, string options)
        {
            var status = await scheduleServices.delete(id, options);
            if (status) 
            {
                return Ok(new { message = "Đã xóa thành công" });
            }
            return BadRequest(new {message = "Xóa thất bại do có người đã đặt lịch này"});
        }
    }
}
