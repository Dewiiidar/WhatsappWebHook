using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatsappWebHook.Models
{
    public class Entry
    {
        public string id { get; set; }
        public List<Change> changes { get; set; }
    }
}