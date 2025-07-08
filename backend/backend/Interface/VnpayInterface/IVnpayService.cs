using Microsoft.AspNetCore.Mvc;

namespace backend.Interface.VnpayInterface
{
    public interface IVnpayService
    {
        string createURL(long amout, string orderID , HttpContext httpContext);

        Task<IActionResult> callbackURL();
    }
}
