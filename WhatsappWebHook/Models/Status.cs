using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatsappWebHook.Models
{
    public class Status
    {
        public string id { get; set; }
        public string status { get; set; }
        public string timestamp { get; set; }
        public string recipient_id { get; set; }
        public Conversation conversation { get; set; }
        public Pricing pricing { get; set; }
    }
}