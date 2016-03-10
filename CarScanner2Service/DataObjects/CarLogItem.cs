using Microsoft.Azure.Mobile.Server;
using System;

namespace CarScanner2Service.DataObjects
{
    public class CarLogItem : EntityData
    {
        public string UserId { get; set; }

        public string TripId { get; set; }

        public DateTime Time { get; set; }

        public int RPM { get; set; }
        public int Speed { get; set; }  
        public int RunTime { get; set; }
        public int Distance { get; set; }
        public int Throttle { get; set; }
    }
}