namespace be_asa_shared_contracts.DTO.Messaging.RabbitMQ
{
    public  class UserSyncIntegrationEvent
    {
        public Guid UserId { get; set; }
        public string? CustomerCode { get; set; }
        public string? Name { get; set; }
        public string? Avatar { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset? UpdatedTime { get; set; }
    }
}
