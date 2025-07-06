using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.Services.Auth;
using backend.Interface.Account;
using backend.ModelDTO.Auth.AuthRespond;
using backend.ModelDTO.Auth.AuthRequest;
using backend.Model.Auth;
using BCrypt.Net;
using backend.Interface.Auth;
using Microsoft.AspNetCore.Authorization;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        // DI

        private readonly IAuth _IAuth;
        public AuthController(IAuth _IAuth)
        {
            this._IAuth = _IAuth;
        }

        [HttpPost("register")]
        public async Task<IActionResult> register(registerRequestDTO registerRequestDTO)
        {
            if (registerRequestDTO != null)
            {
                var getRespondDTO = await _IAuth.Register(registerRequestDTO);
                await _IAuth.SaveChanges();
                return Ok(getRespondDTO);
            }

            var newRegisterRespondDTOError = new registerRespondDTO()
            {
                statusCode = StatusCodes.Status400BadRequest ,
                message = "Lỗi"
            };
            return BadRequest(newRegisterRespondDTOError);
        }

        [HttpPost("login")]
        public async Task<IActionResult> login(loginRequestDTO loginRequestDTO)
        {
            if (loginRequestDTO != null)
            {
                var getStatus = await _IAuth.Login(loginRequestDTO);
                return Ok(getStatus);
            }
            return BadRequest();
        }
    }
}
