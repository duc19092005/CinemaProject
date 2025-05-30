using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.Data;
using backend.Model.Auth;
using backend.ModelDTO.Auth;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly DataContext _dbcontext;

        public userController(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
