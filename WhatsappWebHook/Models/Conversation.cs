using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatsappWebHook.Models
{
    public class Conversation
    {
        public string id { get; set; }
        public string expiration_timestamp { get; set; }
        public Origin origin { get; set; }
    }
}