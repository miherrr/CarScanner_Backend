using Microsoft.Azure.Mobile.Server;
using System;

namespace CarScanner2Service.DataObjects
{
    public class TripItem : EntityData
    {
        public string UserId { get; set; }

        public string TripId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}