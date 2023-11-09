using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatsappWebHook.Models
{
    public class Pricing
    {
        public bool billable { get; set; }
        public string pricing_model { get; set; }
        public string category { get; set; }
    }
}