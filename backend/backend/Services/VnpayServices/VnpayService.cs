using backend.Interface.VnpayInterface;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using VNPAY.NET;
using VNPAY.NET.Models;
using VNPAY.NET.Utilities;

namespace backend.Services.VnpayServices
{
    public class VnpayService : IVnpayService
    {
        private readonly IVnpay vnpay;

        private readonly IConfiguration configuration;

        public VnpayService(IVnpay vnpay , IConfiguration configuration)
        {
            this.vnpay = vnpay;
            this.configuration = configuration;
            this.vnpay.Initialize(this.configuration["Vnpay:Tmd_Code"], this.configuration["Vnpay:SecureHash"], "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html", this.configuration["Vnpay:vnp_ReturnUrl"]);
        }

        public string createURL(long amount, string orderID , HttpContext httpContext)
        {
            try
            {
                var ipAddress = NetworkHelper.GetIpAddress(httpContext);
                Console.WriteLine(ipAddress);
                var request = new PaymentRequest()
                {
                    PaymentId = DateTime.Now.Ticks,
                    Money = amount,
                    Description = $"Đây là đơn thanh toán cho đơn hàng số {orderID}",
                    BankCode = VNPAY.NET.Enums.BankCode.ANY,
                    CreatedDate = DateTime.Now,
                    Currency = VNPAY.NET.Enums.Currency.VND,
                    Language = VNPAY.NET.Enums.DisplayLanguage.Vietnamese ,
                    IpAddress = ipAddress
                    
                };

                var paymentURL = vnpay.GetPaymentUrl(request);

                return paymentURL;
            }
            catch (Exception ex) 
            {
                return ex.Message;
            }
        }

        public Task<IActionResult> callbackURL()
        {
            return null!;
        }
    }
}
