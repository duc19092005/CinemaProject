using backend.ModelDTO.Account;
using backend.ModelDTO.Account.AccountRequest;
using backend.ModelDTO.Account.AccountRespond;

namespace backend.Interface.Account
{
    public interface IAccount
    {
        profileRespond getProfileRespond(string id);

        bool postProfileRequest(string id, profileRequest profileRequest);
    }
}
