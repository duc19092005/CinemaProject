using backend.Request;
using backend.Request.Auth;
using backend.ModelDTO.Auth.AuthRespond;
namespace backend.Interface.Auth
{
    // Các Interfaces Authentication , author
    public interface IAuth
    {
        // Tạm thời để boolean

        registerRespondDTO Register(registerRequest registerRequest);

        // Trả về một token nếu đăng nhập thành công
        // Tạm thời chưa trả về model

        string AuthRequsest(loginRequest loginRequest);

    }
}
