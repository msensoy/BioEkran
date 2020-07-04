using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UygulamaUI.Models
{
    public class User
    {
        public IEnumerable<Device> Devices { get; set; }
        public string UName { get; set; }
        public string DeviceGuid { get; set; }
    }
}
