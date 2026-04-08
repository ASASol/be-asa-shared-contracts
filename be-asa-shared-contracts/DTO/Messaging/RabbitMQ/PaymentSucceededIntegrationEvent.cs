namespace be_asa_shared_contracts.DTO.Messaging.RabbitMQ
{
    public class PaymentSucceededIntegrationEvent
    {
        public string PmCheckCode { get; set; } = null!;        // MaSo/ID... của Đơn hàng/Booking.... cần xử lý thanh toán
        public string PmTableCode { get; set; } = null!;        // Tên bảng lưu PmCheckCode
        public string PmModuleCode { get; set; } = null!;       // Module gọi thanh toán:food-order. 
        public string PaymentGroup { get; set; } = default!;     //Direct / OnePay / VNPay / ....
        public string? PaymentMethod { get; set; } = default!;   // Cash / Card / QR / OP
        public string Status { get; set; } = default!;          // Success
        public decimal Amount { get; set; }
        public string UserName { get; set; }
        public DateTimeOffset PaidAt { get; set; }
    }
}
