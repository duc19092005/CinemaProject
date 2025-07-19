using System.ComponentModel.DataAnnotations;

namespace backend.ModelDTO.Account.AccountRequest;

public class ChangePasswordDTO
{
    public string OldPassword { get; set; } = String.Empty;
    
    public string NewPassword { get; set; } = String.Empty;
    
    [Compare("NewPassword" , ErrorMessage ="The new password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; } = String.Empty;
}