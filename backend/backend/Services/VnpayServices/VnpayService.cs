using backend.Helper;
using backend.Interface.VnpayInterface;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Cryptography;
using System.Text.Encodings.Web;
using VNPAY.NET;
using VNPAY.NET.Models;
using VNPAY.NET.Utilities;

namespace backend.Services.VnpayServices
{
    public class VnpayService : IVnpayService
    {
        private readonly IConfiguration configuration;

        public VnpayService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string createURL(long amount, string orderID , HttpContext httpContext)
        {
            try
            {
                var ipAddress = NetworkHelper.GetIpAddress(httpContext);
                Console.WriteLine(ipAddress);
                //var request = new PaymentRequest()
                //{
                //    PaymentId = DateTime.Now.Ticks,
                //    Money = amount,
                //    Description = $"Đây là đơn thanh toán cho đơn hàng số {orderID}",
                //    BankCode = VNPAY.NET.Enums.BankCode.ANY,
                //    CreatedDate = DateTime.Now,
                //    Currency = VNPAY.NET.Enums.Currency.VND,
                //    Language = VNPAY.NET.Enums.DisplayLanguage.Vietnamese ,
                //    IpAddress = ipAddress ,  
                //};

                //var paymentURL = vnpay.GetPaymentUrl(request);

                var newUrlParams = new VnpayURLParams
                    (configuration["Vnpay:Tmd_Code"] , amount , ipAddress
                    , $"Đây là đơn thanh toán cho đơn hàng số {orderID}" , configuration["Vnpay:vnp_ReturnUrl"] , orderID);

                var VnpaySandboxURL = "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html";

                // Các Params 

                Dictionary<string, string> VnpayParams = new Dictionary<string, string>()
                {
                    {"vnp_Version" , newUrlParams.vnp_Version } ,
                    {"vnp_Command" , newUrlParams.vnp_Command} ,
                    {"vnp_TmnCode" , newUrlParams.vnp_TmnCode} ,
                    {"vnp_Amount" , (newUrlParams.vnp_Amount * 100).ToString()} ,
                    {"vnp_CreateDate" , newUrlParams.vnp_CreateDate} ,
                    {"vnp_CurrCode" , newUrlParams.vnp_CurrCode} ,
                    {"vnp_IpAddr" , newUrlParams.vnp_IpAddr} ,
                    {"vnp_Locale" , newUrlParams.vnp_Locale} ,
                    {"vnp_OrderInfo" , WebUtility.UrlEncode(newUrlParams.vnp_OrderInfo)} ,
                    {"vnp_OrderType" , newUrlParams.vnp_OrderType} ,
                    {"vnp_ReturnUrl" , WebUtility.UrlEncode(newUrlParams.vnp_ReturnUrl) } ,
                    {"vnp_TxnRef" , orderID }
                };

                var orderByParams = VnpayParams.OrderBy(x => x.Key);

                // Convert sang dạng Params của Vnpay Yêu cầu

                var convertToParamsToVnpayRequireParams = orderByParams
                    .Select(x => x.Key + "=" + x.Value);

                // ToURL

                var convertParamsToURL = String.Join("&", convertToParamsToVnpayRequireParams);

                // Mã hóa

                var convertToSHA512 = SHA512_Helper.SHA512_ComputeHash(convertParamsToURL, configuration["Vnpay:SecureHash"]);

                // Chuyển sang dạng URL của VNPAY để tạo yêu cầu request

                var convertToURL = 
                    VnpaySandboxURL + 
                    "?" + 
                    convertParamsToURL 
                    + 
                    "&" + 
                    "vnp_SecureHash" + 
                    "=" + 
                    convertToSHA512;

                return convertToURL;


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
