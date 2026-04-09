namespace be_asa_shared_contracts.DTO.Messaging.RabbitMQ
{
    public class PaymentSucceededIntegrationEvent
    {
        public string PmCheckCode { get; set; } = null!;        // MaSo/ID... của Đơn hàng/Booking.... cần xử lý thanh toán
        public string PmTableCode { get; set; } = null!;        // Tên bảng lưu PmCheckCode
        public string PmModuleCode { get; set; } = null!;       // Module gọi thanh toán:food-order.
                                                                // 
        /// <summary>
        /// Thông tin phương thức thanh toán được cổng thanh toán trả về.
        /// - PaymentMethod: tên/giá trị phương thức thanh toán.
        /// - PaymentMethodCode: mã phương thức thanh toán.
        /// Chỉ cần có 1 trong 2 trường có dữ liệu, trường còn lại có thể null.
        /// </summary>
        public string? PaymentGroup { get; set; } = default!;   // Direct / OnePay / VNPay / ....
        public string? PaymentMethod { get; set; } = default!;  // Phương thức thanh toán do cổng thanh toán trả về
        public string? PaymentMethodCode { get; set; }          // Mã phương thức thanh toán, có thể null nếu đã có PaymentMethod

        public string Status { get; set; } = default!;          // Success
        public decimal Amount { get; set; }
        public string UserName { get; set; }
        public DateTimeOffset PaidAt { get; set; }
    }
}
