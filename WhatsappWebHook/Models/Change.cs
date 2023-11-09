using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatsappWebHook.Models
{
    public class Change
    {
        public Value value { get; set; }
        public string field { get; set; }
    }
}