namespace be_asa_shared_contracts.DTO.Messaging.RabbitMQ
{
    public class SendEmailQueuePayload
    {
        public string ConfigKey { get; set; } = "Default";
        public string? To { get; set; }
        public List<string>? Cc { get; set; }
        public List<string>? Bcc { get; set; }
        public string Subject { get; set; } = default!;
        public string Body { get; set; } = default!;
        public List<EmailAttachmentQueuePayload>? Attachments { get; set; }

    }
}
