using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UygulamaUI.Models
{
    public class SensorData
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int DeviceId { get; set; }
        public double? Value { get; set; }
        public string Time { get; set; }
    }
}
