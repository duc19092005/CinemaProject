using backend.Data;
using backend.Enum;
using backend.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web; // For HttpUtility.UrlDecode
using VNPAY.NET.Enums;
using VNPAY.NET.Models;
using VNPAY.NET.Utilities;

namespace backend.Controllers
{
    [Route("Vnpay")]
    [ApiController]
    public class VnpayController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public VnpayController(DataContext dataContext) 
        {
            this._dataContext = dataContext;
        }
        [HttpGet("IPN")]
        public IActionResult IPN()
        {
            var queryParams = HttpContext.Request.Query;

            var vnpAmount = queryParams["vnp_Amount"].ToString();
            var vnpBankCode = queryParams["vnp_BankCode"].ToString();
            var vnpBankTranNo = queryParams["vnp_BankTranNo"].ToString();
            var vnpCardType = queryParams["vnp_CardType"].ToString();
            var vnpOrderInfo = queryParams["vnp_OrderInfo"].ToString();
            var vnpPayDate = queryParams["vnp_PayDate"].ToString();
            var vnpResponseCode = queryParams["vnp_ResponseCode"].ToString();
            var vnpTmnCode = queryParams["vnp_TmnCode"].ToString();
            var vnpTxnRef = queryParams["vnp_TxnRef"].ToString(); // vnp_TxnRef is often the OrderId you sent
            var vnpTransactionNo = queryParams["vnp_TransactionNo"].ToString();


            if (string.IsNullOrEmpty(vnpAmount) ||
                string.IsNullOrEmpty(vnpBankCode) ||
                string.IsNullOrEmpty(vnpBankTranNo) ||
                string.IsNullOrEmpty(vnpCardType) ||
                string.IsNullOrEmpty(vnpOrderInfo) ||
                string.IsNullOrEmpty(vnpPayDate) ||
                string.IsNullOrEmpty(vnpResponseCode) ||
                string.IsNullOrEmpty(vnpTmnCode) ||
                string.IsNullOrEmpty(vnpTxnRef) ||
                string.IsNullOrEmpty(vnpTransactionNo))
            {
                Console.WriteLine("Null rồi");
                // Return a Bad Request if any essential parameter is missing.
                return BadRequest("Missing one or more required VNPAY callback parameters. Please check the URL.");
            }

            // ---
            // Process the VNPAY response code to get a human-readable message
            // ---
            string responseMessage = string.Empty;
            switch (vnpResponseCode)
            {
                case "00":
                    responseMessage = "Giao dịch thành công";
                    break;
                case "07":
                    responseMessage = "Trừ tiền thành công. Giao dịch bị nghi ngờ (liên quan tới lừa đảo, giao dịch bất thường)";
                    break;
                case "09":
                    responseMessage = "Thẻ hoặc tài khoản chưa đăng ký dịch vụ Internet Banking tại ngân hàng";
                    break;
                case "10":
                    responseMessage = "Xác thực thông tin thẻ hoặc tài khoản không đúng quá 3 lần";
                    break;
                case "11":
                    responseMessage = "Hết hạn chờ thanh toán";
                    break;
                case "12":
                    responseMessage = "Thẻ hoặc tài khoản ngân hàng của quý khách bị khóa";
                    break;
                case "13":
                    responseMessage = "Mã OTP không chính xác";
                    break;
                case "24":
                    responseMessage = "Giao dịch bị hủy bởi người dùng";
                    break;
                case "51":
                    responseMessage = "Tài khoản của không đủ số dư để thực hiện giao dịch";
                    break;
                case "65":
                    responseMessage = "Tài khoản đã vượt quá hạn mức giao dịch trong ngày";
                    break;
                case "75":
                    responseMessage = "Ngân hàng thanh toán đang bảo trì";
                    break;
                case "79":
                    responseMessage = "Nhập sai mật khẩu thanh toán quá số lần quy định";
                    break;
                case "99":
                    responseMessage = "Lỗi không xác định";
                    break;
                default:
                    responseMessage = "Mã trạng thái không xác định.";
                    break;
            }

            long amountParsed;
            if (!long.TryParse(vnpAmount, out amountParsed))
            {
                return BadRequest("Invalid amount received from VNPAY.");
            }

            var getOrderID = _dataContext.Order.FirstOrDefault
                (x => x.orderId.Equals(vnpTxnRef));
            if (getOrderID != null)
            {
                try
                {
                    if (vnpResponseCode != "00")
                    {
                        getOrderID.PaymentStatus = PaymentStatus.PaymentFailure.ToString();
                        getOrderID.message = responseMessage;

                        _dataContext.Order.Update(getOrderID);
                    }
                    getOrderID.PaymentStatus = PaymentStatus.PaymentSuccess.ToString();
                    getOrderID.message = responseMessage;
                    
                    _dataContext.Order.Update(getOrderID);
                    _dataContext.SaveChanges();

                    return Ok("Cập nhật thành công");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return BadRequest("Không tìm thấy orderID");
        }

        [HttpGet("getPaymentStatus/{orderID}")]
        public IActionResult getPaymentStatus(string orderID)
        {
            var findOrderID = _dataContext.Order.FirstOrDefault(x => x.orderId.Equals(orderID));
            if (findOrderID != null) 
            {
                return BadRequest();
            }
            return Ok(findOrderID);
        }

        [HttpGet("CallbackURL")]
        public IActionResult VnpayCallBackURL()
        {
            // Get all query parameters from the HTTP context
            var queryParams = HttpContext.Request.Query;

            // Extract values, handling potential nulls from the query string
            // We use GetValueOrDefault to assign string.Empty if a parameter is missing,
            // which simplifies null checks later for strings.
            var vnpAmount = queryParams["vnp_Amount"].ToString();
            var vnpBankCode = queryParams["vnp_BankCode"].ToString();
            var vnpBankTranNo = queryParams["vnp_BankTranNo"].ToString();
            var vnpCardType = queryParams["vnp_CardType"].ToString();
            var vnpOrderInfo = queryParams["vnp_OrderInfo"].ToString();
            var vnpPayDate = queryParams["vnp_PayDate"].ToString();
            var vnpResponseCode = queryParams["vnp_ResponseCode"].ToString();
            var vnpTmnCode = queryParams["vnp_TmnCode"].ToString();
            var vnpTxnRef = queryParams["vnp_TxnRef"].ToString(); // vnp_TxnRef is often the OrderId you sent
            var vnpTransactionNo = queryParams["vnp_TransactionNo"].ToString();

            // ---
            // Input Validation: Check for required parameters
            // This ensures we have all the data before proceeding.
            // ---
            if (string.IsNullOrEmpty(vnpAmount) ||
                string.IsNullOrEmpty(vnpBankCode) ||
                string.IsNullOrEmpty(vnpBankTranNo) ||
                string.IsNullOrEmpty(vnpCardType) ||
                string.IsNullOrEmpty(vnpOrderInfo) ||
                string.IsNullOrEmpty(vnpPayDate) ||
                string.IsNullOrEmpty(vnpResponseCode) ||
                string.IsNullOrEmpty(vnpTmnCode) ||
                string.IsNullOrEmpty(vnpTxnRef) ||
                string.IsNullOrEmpty(vnpTransactionNo))
            {
                Console.WriteLine("Null rồi");
                // Return a Bad Request if any essential parameter is missing.
                return BadRequest("Missing one or more required VNPAY callback parameters. Please check the URL.");
            }

            // ---
            // Process the VNPAY response code to get a human-readable message
            // ---
            string responseMessage = string.Empty;
            switch (vnpResponseCode)
            {
                case "00":
                    responseMessage = "Giao dịch thành công";
                    break;
                case "07":
                    responseMessage = "Trừ tiền thành công. Giao dịch bị nghi ngờ (liên quan tới lừa đảo, giao dịch bất thường)";
                    break;
                case "09":
                    responseMessage = "Thẻ hoặc tài khoản chưa đăng ký dịch vụ Internet Banking tại ngân hàng";
                    break;
                case "10":
                    responseMessage = "Xác thực thông tin thẻ hoặc tài khoản không đúng quá 3 lần";
                    break;
                case "11":
                    responseMessage = "Hết hạn chờ thanh toán";
                    break;
                case "12":
                    responseMessage = "Thẻ hoặc tài khoản ngân hàng của quý khách bị khóa";
                    break;
                case "13":
                    responseMessage = "Mã OTP không chính xác";
                    break;
                case "24":
                    responseMessage = "Giao dịch bị hủy bởi người dùng";
                    break;
                case "51":
                    responseMessage = "Tài khoản của không đủ số dư để thực hiện giao dịch";
                    break;
                case "65":
                    responseMessage = "Tài khoản đã vượt quá hạn mức giao dịch trong ngày";
                    break;
                case "75":
                    responseMessage = "Ngân hàng thanh toán đang bảo trì";
                    break;
                case "79":
                    responseMessage = "Nhập sai mật khẩu thanh toán quá số lần quy định";
                    break;
                case "99":
                    responseMessage = "Lỗi không xác định";
                    break;
                default:
                    responseMessage = "Mã trạng thái không xác định.";
                    break;
            }

            // ---
            // Construct the VnpayCallbackRespond object
            // Ensure proper type conversion (e.g., long for vnp_Amount)
            // ---
            long amountParsed;
            if (!long.TryParse(vnpAmount, out amountParsed))
            {
                // Handle case where vnp_Amount is not a valid long
                return BadRequest("Invalid amount received from VNPAY.");
            }

            var callbackData = new VnpayCallbackRespond
            (
                vnp_Amount: amountParsed,
                vnp_BankCode: vnpBankCode,
                vnp_BankTranNo: vnpBankTranNo,
                vnp_CardType: vnpCardType,
                vnp_OrderInfo: HttpUtility.UrlDecode(vnpOrderInfo), // Decode order info
                vnp_PayDate: vnpPayDate,
                vnp_ResponseCode: vnpResponseCode,
                vnp_TmnCode: vnpTmnCode,
                vnp_TransactionNo: vnpTransactionNo,
                vnp_message: responseMessage // Use the human-readable message
            );

            // You might want to do further processing here, like:
            // 1. Verify the signature (vnp_SecureHash) if VNPAY sends it (highly recommended for security!)
            //    This is crucial to ensure the callback hasn't been tampered with.
            // 2. Update your order status in your database based on vnpTxnRef (your order ID)
            // 3. Log the callback details for auditing

            // Return the constructed object with a 200 OK status
            Console.WriteLine(callbackData.vnp_message);
            return Ok(callbackData);
        }
    }
}