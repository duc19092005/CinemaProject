public class VnpayCallbackRespond
{
    public long vnp_Amount { get; set; }
    public string vnp_BankCode { get; set; } = string.Empty;
    public string vnp_BankTranNo { get; set; } = string.Empty;
    public string vnp_CardType { get; set; } = string.Empty;
    public string vnp_OrderInfo { get; set; } = string.Empty;
    public string vnp_PayDate { get; set; } = string.Empty;
    public string vnp_ResponseCode { get; set; } = string.Empty;
    public string vnp_TmnCode { get; set; } = string.Empty;
    public string vnp_TransactionNo { get; set; } = string.Empty;
    public string vnp_message { get; set; } = string.Empty;

    public VnpayCallbackRespond(
        long vnp_Amount,
        string vnp_BankCode,
        string vnp_BankTranNo,
        string vnp_CardType,
        string vnp_OrderInfo,
        string vnp_PayDate,
        string vnp_ResponseCode,
        string vnp_TmnCode,
        string vnp_TransactionNo,
        string vnp_message)
    {
        this.vnp_Amount = vnp_Amount;
        this.vnp_BankCode = vnp_BankCode;
        this.vnp_BankTranNo = vnp_BankTranNo;
        this.vnp_CardType = vnp_CardType;
        this.vnp_OrderInfo = vnp_OrderInfo;
        this.vnp_PayDate = vnp_PayDate;
        this.vnp_ResponseCode = vnp_ResponseCode;
        this.vnp_TmnCode = vnp_TmnCode;
        this.vnp_TransactionNo = vnp_TransactionNo;
        this.vnp_message = vnp_message;
    }

    // You can also add an empty constructor if needed, for example, for deserialization
    public VnpayCallbackRespond() { }
}