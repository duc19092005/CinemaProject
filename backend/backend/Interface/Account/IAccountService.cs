using backend.ModelDTO.Account;
using backend.ModelDTO.Account.AccountRequest;
using backend.ModelDTO.Account.AccountRespond;
using backend.ModelDTO.GenericRespond;

namespace backend.Interface.Account
{
    public interface IAccountService
    {
        GenericRespondWithObjectDTO<ProfileRespond> getProfileRespond(string id);
        
        GenericRespondDTOs editProfileRequest(string id , profileRequest profileRequest);

        GenericRespondDTOs ChangePassword(string userId  , ChangePasswordDTO dtos);
    }
}
