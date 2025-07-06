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
                return new registerRespondDTO { statusCode = StatusCodes.Status201Created, message = "Đã tạo thành công" };
            }
            return new registerRespondDTO { statusCode = StatusCodes.Status400BadRequest, message = "Đã tạo thành công" };
        }

        public async Task<loginRespondDTO> Login(loginRequestDTO loginRequest)
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

                var getToken = generateToken(claims , checkLoginRequest.loginUserEmail);

                if (getToken != null)
                {
                    return getToken;
                }

            }
            return null!;
        }

        private userInformation checkLogin(loginRequestDTO loginRequest)
        {
            var findUser =  _dataContext.userInformation.FirstOrDefault
                (x => x.loginUserEmail.Equals(loginRequest.loginUserName)
                && x.loginUserPassword.Equals(loginRequest.loginUserPassword));
            if (findUser != null)
            {
                return findUser;
            }
            return null;
        }

        private loginRespondDTO generateToken(List<Claim> claims , string Email)
        {
            var getJWTKey = _configuration["Jwt:Key"];

            /*
             * "Jwt": {
                "Key": "6d2541e1901b00052daeef50166f9144c885437cd7c244a52a6996b0d65e43f1744209f2fcff45019d190a41385462655296b9735732ceb012001ff6bfa5f29701ac45cff6528134c4cd96b5c7bcf27f09b6091fc31b0b93c672f64cc11a56fe22714b76b8cd7658a2e5ef5b3b5f80ae8fa2c67d0d43eb769c2e3c9a552db2195d1439883c197b77e3fe06bbb71c252a0e710f8e6ec8ff4b8c81f956d05bb2d395aa970befc7bfeca35c3184a23516940a62f8b34933b85d2f1616aed6ca5c9b18aa615a969497972ce1198d74483ecd32866b5d15c31180e98139ca97b90257073bf3f5f6f820ab388911a7052ad761009b27f522bc369b4536d9027de55754",
                "Iss": "http://localhost:5229",
                "Aud": "http://localhost:5229"
                },
             */
            if (getJWTKey != null)
            {
                var SecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(getJWTKey));
                var SigningCreatical = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256);
                var Hour = DateTime.Now.AddHours(1);
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
