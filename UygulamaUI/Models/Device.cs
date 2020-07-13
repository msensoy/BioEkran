using System;
using System.Linq;

namespace UygulamaUI.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DeviceGUID { get; set; }
        public string Programs { get; set; }
        public string AutoState { get; set; }
        public string WorkingMode { get; set; }
        public bool ValveState { get; set; }
        public bool PumpState { get; set; }
        public bool MotorState { get; set; }
        public int Threshold { get; set; }
        public int WaterEntryTime { get; set; }
        public int CycleCount { get; set; }
        public int DryingTime { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }

        private double waterLevel;
        public double WaterLevel
        {
            get { return Math.Max(0, (Math.Round((100 - ((waterLevel - 7) / 27 * 100)), 1))); }
            set { waterLevel = value; }
        }
    }
}
