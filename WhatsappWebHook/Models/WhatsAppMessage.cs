using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatsappWebHook.Models
{
    public class WhatsAppMessage
    {
        public string @object { get; set; }
        public List<Entry> entry { get; set; }
    }
}