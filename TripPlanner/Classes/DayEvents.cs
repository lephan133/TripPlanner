using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner.Classes
{
    public class DayEvents
    {
        public string Activities { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Locations { get; set; }
        public string Notes { get; set; }
        public Guid DayEventID { get; set; }
    }
}
