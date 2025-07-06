using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.Data;
using backend.Model.Auth;
using backend.ModelDTO.Auth;
using Microsoft.EntityFrameworkCore;
using backend.Interface.Customter;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly DataContext _dbcontext;
        private readonly IOrderDetail orderDetail;

        public userController(DataContext dbcontext , IOrderDetail orderDetail)
        {
            _dbcontext = dbcontext;
            this.orderDetail = orderDetail;
        }

        [HttpGet("getAllUser")]
        public IActionResult Get()
        {
            return Ok(_dbcontext.userInformation.ToList());
        }

        [HttpGet("getOrderID/{id}")]
        public IActionResult GetOrderDetail(string id)
        {
            try
            {
                var getOrder = orderDetail.GetOrderDetailRespond(id);
                if (getOrder != null)
                {
                    return Ok(getOrder);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
