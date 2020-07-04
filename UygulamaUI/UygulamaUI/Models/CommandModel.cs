using System;
using System.Collections.Generic;
using System.Text;

namespace UygulamaUI.Models
{
    public class CommandModel
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Value { get; set; }
        public string Time { get; set; }
    }
}
