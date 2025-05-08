using backend.Model;
using Microsoft.AspNetCore.Mvc;
using backend.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly DataContext dataContext;
        public ValuesController(DataContext dataContext) { this.dataContext = dataContext; }


        [HttpGet("getData")]
        public IActionResult Get()
        {
            var getData = dataContext.User.ToList();
            return Ok(getData);
        }

        [HttpPost("PostData")]
        public IActionResult Post(UserModel userModel)
        {
            dataContext.Add(userModel);
            dataContext.SaveChanges();
            return Ok();
        }
    }
}
