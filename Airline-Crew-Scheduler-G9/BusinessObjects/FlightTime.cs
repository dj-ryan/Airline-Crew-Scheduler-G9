using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class FlightTime
    {
        public int TimeID { get; set; }
        public DateTime? ScheduledTakeoffTime { get; set; }
        public DateTime? EstimatedTakeoffTime { get; set; }
        public DateTime? ActualTakeoffTime { get; set; }
        public DateTime? ScheduledTouchdownTime { get; set; }
        public DateTime? EstimatedTouchdownTime { get; set; }
        public DateTime? ActualTouchdownTime { get; set; }

        public FlightTime( int timeID,
                      DateTime scheduledTakeoffTime, DateTime estimatedTakeoffTime,
                      DateTime scheduledTouchdownTime, DateTime estimatedTouchDownTime)
        {
            TimeID = timeID;
            ScheduledTakeoffTime = scheduledTakeoffTime;
            EstimatedTakeoffTime = estimatedTakeoffTime;
            ScheduledTouchdownTime = scheduledTouchdownTime;
            EstimatedTouchdownTime = estimatedTouchDownTime;
            ActualTakeoffTime = null;
            ActualTouchdownTime = null;

        }
    }
}
