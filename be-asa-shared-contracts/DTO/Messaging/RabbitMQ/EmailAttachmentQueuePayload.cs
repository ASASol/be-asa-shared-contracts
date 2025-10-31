using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_asa_shared_contracts.DTO.Messaging.RabbitMQ
{
    public class EmailAttachmentQueuePayload
    {
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string Base64Content { get; set; }
    }
}
