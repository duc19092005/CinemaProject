using backend.Data;
using backend.Migrations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestCaseController : ControllerBase
    {
        private readonly DataContext dataContext;

        public TestCaseController(DataContext dataContext) 
        { 
            this.dataContext = dataContext;
        }

        [HttpGet("getAllCustomer")]
        public ActionResult Get() 
        {
            var getAll = dataContext.Customers.ToList();
            return Ok(getAll);
        }

        [HttpGet("getAllSchedule")]
        public ActionResult GetSchedules() 
        { 
            var getAll = dataContext.movieSchedule.ToList();
            return Ok(getAll);
        }

        [HttpGet("getAllSeats")]

        public ActionResult GetSeatsCase() 
        { 
            var getAll = dataContext.Seats.ToList();
            return Ok(getAll);
        }

        [HttpGet("getAllUserTypes")]

        public ActionResult GetuserTypes()
        {
            var getAll = dataContext.userType.ToList();
            return Ok(getAll);
        }
    }
}
