namespace backend.Helper
{
    public class VnpayURLParams
    {
        public string vnp_Version { get; set; } = "2.1.0";

        public string vnp_Command { get; set; } = "pay";

        public string vnp_TmnCode { get; set; } = string.Empty;

        public long vnp_Amount { get; set; }

        public string vnp_CreateDate { get; set; } = DateTime.Now.ToString("yyyyMMddHHmmss");

        public string vnp_CurrCode { get; set; } = "VND";

        public string vnp_IpAddr { get; set; } = string.Empty;

        public string vnp_Locale { get; set; } = "vn";

        public string vnp_OrderInfo { get; set; } = string.Empty;

        public string vnp_OrderType { get; set; } = "other";

        public string vnp_ReturnUrl { get; set; } = string.Empty;

        public string vnp_TxnRef { get; set; } = string.Empty;

        public VnpayURLParams
            (string vnp_TmnCode, long vnp_Amount, string vnp_IpAddr,
            string vnp_OrderInfo, string vnp_ReturnUrl, string vnp_TxnRef)
        {
            this.vnp_TmnCode = vnp_TmnCode;
            this.vnp_Amount = vnp_Amount;
            this.vnp_IpAddr = vnp_IpAddr;
            this.vnp_OrderInfo = vnp_OrderInfo;
            this.vnp_ReturnUrl = vnp_ReturnUrl;
            this.vnp_TxnRef = vnp_TxnRef;
        }

    }
}
