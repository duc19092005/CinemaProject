using backend.Interface.Auth;
using backend.ModelDTO.Auth.AuthRespond;
using backend.ModelDTO.Auth.AuthRequest;
using backend.Model.Auth;
using backend.Data;

namespace backend.Services.Auth
{
    public class AuthService : IAuth
    {
        private readonly DataContext _dataContext;

        public AuthService(DataContext dataContext)
        {
            _dataContext = dataContext;
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
                    dateOfBirth = registerRequest.dateOfBirth,
                    phoneNumber = registerRequest.phoneNumber,
                    userName = registerRequest.userName,
                    IdentityCode = BryptIdentifyCode,
                    userPoint = 0
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

        public Task<loginRespondDTO> AuthRequsest(loginRequestDTO loginRequest)
        {
            return null!;
        }

        public async Task SaveChanges()
        {
            await _dataContext.SaveChangesAsync();
        }
    }
}
