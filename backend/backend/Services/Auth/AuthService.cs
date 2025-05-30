using backend.Interface.Auth;
using backend.ModelDTO.Auth.AuthRespond;
using backend.Request.Auth;

namespace backend.Services.Auth
{
    public class AuthService : IAuth
    {
        public registerRespondDTO Register(registerRequest registerRequest)
        {
            return null!;
        }

        // Trả về một token nếu đăng nhập thành công
        // Tạm thời chưa trả về model

        public string AuthRequsest(loginRequest loginRequest)
        {
            return string.Empty;
        }
    }
}
