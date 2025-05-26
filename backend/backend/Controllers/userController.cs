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

        [HttpPost("Register")]
        public async Task<IActionResult> newUser([FromForm] userInformationDTO userInformationDTO)
        {
            if (userInformationDTO != null)
            {
                // layas byte cua image
                var getImageByte = new byte[1024];

                using (var memory = new MemoryStream())
                {
                    await userInformationDTO.userImage.CopyToAsync(memory);
                    getImageByte = memory.ToArray();
                }

                var newUser = new userInformation()
                {
                    userId = Guid.NewGuid().ToString(),
                    loginUserName = userInformationDTO.loginUserName,
                    loginUserPassword = userInformationDTO.loginUserPassword,
                    dateOfBirth = userInformationDTO.dateOfBirth,
                    phoneNumber = userInformationDTO.phoneNumber,
                    IdentityCode = userInformationDTO.IdentityCode,
                    userName = userInformationDTO.userName,
                    userPoint = userInformationDTO.userPoint,
                    userImage = getImageByte,
                };

                await _dbcontext.AddAsync(newUser);
                await _dbcontext.SaveChangesAsync();

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet("getUser/{name}")]
        public async Task<IActionResult> getUserByName(string name)
        {
            var findUser = _dbcontext.userInformation.Where(x => x.userName.Contains(name));
            if (await findUser.AnyAsync())
            {
                return Ok(findUser);
            }
            return BadRequest();
        }
        [HttpGet("getAllUser")]

        public List<userInformation> getAllUser()
        {
            return _dbcontext.userInformation.ToList();
        }
    }
}
