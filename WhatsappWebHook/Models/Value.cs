using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatsappWebHook.Models
{
    public class Value
    {
        public string messaging_product { get; set; }
        public MetaData metadata { get; set; }
        public List<Status> statuses { get; set; }
    }
}