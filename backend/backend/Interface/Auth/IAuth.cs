
using backend.ModelDTO.Auth.AuthRespond;
using backend.ModelDTO.Auth.AuthRequest;
namespace backend.Interface.Auth
{
    // Các Interfaces Authentication , author
    public interface IAuth
    {
        // Tạm thời để boolean

        registerRespondDTO Register(registerRequestDTO registerRequest);

        // Trả về một token nếu đăng nhập thành công
        // Tạm thời chưa trả về model

        loginRespondDTO AuthRequsest(loginRequestDTO loginRequest);

    }
}
