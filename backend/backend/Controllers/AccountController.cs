using backend.Enum;
using backend.Interface.Account;
using backend.ModelDTO.Account.AccountRequest;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountController(IAccountService IAccount) : ControllerBase
{
    private readonly IAccountService _IAccount = IAccount;

    [HttpGet("getAccountInfo")]
    public IActionResult GetAccountInfo(string userID)
    {
        var getUserInfoStatus = _IAccount.getProfileRespond(userID);
        if (getUserInfoStatus.Status.Equals(GenericStatusEnum.Failure.ToString()))
        {
            return BadRequest(getUserInfoStatus);
        }
        return Ok(getUserInfoStatus);
    }

    [HttpPost("changePassword")]
    public IActionResult ChangePassword(string userID, ChangePasswordDTO changePasswordDTO)
    {
        var status = _IAccount.ChangePassword(userID, changePasswordDTO);
        if (status.Status.Equals(GenericStatusEnum.Failure.ToString()))
        {
            return BadRequest(status);
        }
        return Ok(status);
    }
}