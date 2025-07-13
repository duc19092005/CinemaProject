using backend.Interface.Auth;
using backend.ModelDTO.Auth.AuthRespond;
using backend.ModelDTO.Auth.AuthRequest;
using backend.Model.Auth;
using backend.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.Extensions.Primitives;
using System.Net.WebSockets;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Logging;
using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Authorization;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using BCrypt.Net;

namespace backend.Services.Auth
{
    public class AuthService : IAuth
    {
        private readonly DataContext _dataContext;

        private readonly IConfiguration _configuration;

        public AuthService(DataContext dataContext, IConfiguration _configuration)
        {
            _dataContext = dataContext;
            this._configuration = _configuration;
        }

        [AllowAnonymous]
        public async Task<registerRespondDTO> Register(registerRequestDTO registerRequest)
        {
            var getCustomerRoleID = _dataContext.roleInformation.FirstOrDefault(x => x.roleName.Equals("Customer"));

            if (getCustomerRoleID != null)
            {
                Guid userID = Guid.NewGuid();
                var BryptPassword = BCrypt.Net.BCrypt.HashPassword(registerRequest.loginUserPassword);
                var BryptIdentifyCode = BCrypt.Net.BCrypt.HashPassword(registerRequest.IdentityCode);
                var newUserInformarion = new userInformation()
                {
                    userId = userID.ToString(),
                    loginUserEmail = registerRequest.loginEmail,
                    loginUserPassword = BryptPassword,
                    
                };
                await _dataContext.userInformation.AddAsync(newUserInformarion);

                var newUserRoleInformation = new userRoleInformation()
                {
                    userId = userID.ToString(),
                    roleId = getCustomerRoleID.roleId
                };
                await _dataContext.userRoleInformation.AddAsync(newUserRoleInformation);

                var addNewUserInfo = new userInformation()
                {

                };
                return new registerRespondDTO { statusCode = StatusCodes.Status201Created, message = "Đã tạo thành công" };
            }
            return new registerRespondDTO { statusCode = StatusCodes.Status400BadRequest, message = "Đã tạo thành công" };
        }

        [AllowAnonymous]
        public loginRespondDTO Login(loginRequestDTO loginRequest)
        {
            try
            {
                var checkLoginRequest = checkLogin(loginRequest);
                if (checkLoginRequest != null)
                {
                    // Lấy ID
                    var getID = checkLoginRequest.userId;
                    // Lấy ID role trong bảng quan hệ n-n
                    var getRole = _dataContext.userRoleInformation.Where(x => x.userId.Equals(getID)).Select(x => x.roleId).ToList();
                    // Lấy RoleName
                    var getRoleList = _dataContext.roleInformation.Where(x => getRole.Contains(x.roleId)).Select(x => x.roleName).ToList();

                    // Tạo Claims để làm JWT
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name , loginRequest.loginUserName),
                };

                    foreach (var roleName in getRoleList)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, roleName));
                    }

                    var getToken = generateToken(claims, checkLoginRequest.loginUserEmail);

                    if (getToken != null)
                    {
                        return getToken;
                    }
                }
                return new loginRespondDTO()
                {
                    message = "Error"
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null!;
            }
        }

        private userInformation checkLogin(loginRequestDTO loginRequest)
        {
            try
            {
                var findUser = _dataContext.userInformation.FirstOrDefault
                (x => x.loginUserEmail.Equals(loginRequest.loginUserName));
                if (findUser != null)
                {
                    // Kiểm tra có đúng mk hay không
                    var checkPassword = BCrypt.Net.BCrypt.Verify(loginRequest.loginUserPassword, findUser.loginUserPassword);
                    if (checkPassword)
                    {
                        return findUser;
                    }
                    return null!;
                }
                return null!;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null!;
            }
        }

        private loginRespondDTO generateToken(List<Claim> claims , string Email)
        {
            var getJWTKey = _configuration["Jwt:Key"];

            /*
             * 
             */
            if (getJWTKey != null)
            {
                // Tạo header
                var SecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(getJWTKey));
                // Tạo header
                var SigningCreatical = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256);
                var Hour = DateTime.Now.AddHours(1);
                // Tạo JWT_Token
                var genrateTokenString = new JwtSecurityToken
                    (_configuration["Jwt:Iss"],
                    _configuration["Jwt:Aud"],
                    claims, 
                    DateTime.Now,
                    Hour, SigningCreatical
                    );

                var gettingToken = new JwtSecurityTokenHandler().WriteToken(genrateTokenString);

                var getToken = new JwtSecurityTokenHandler().ReadToken(gettingToken);

                var newAuthRepond = new loginRespondDTO()
                {
                    tokenID = gettingToken ,
                    userID = Email,
                    expDate = Hour.ToString(),
                    message = "Success"
                };
                return newAuthRepond;
            }
            return null! ;
        }

        public async Task SaveChanges()
        {
            await _dataContext.SaveChangesAsync();
        }
    }
}
