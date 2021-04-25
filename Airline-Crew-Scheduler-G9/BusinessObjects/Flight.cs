using System;

namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Flight
    {
        //todo: add takeoff/ touchdown times
        public int FlightNumber { get; set; }
        public Aircraft FlightAircraft { get; set; }
        public Airport OriginAirport { get; set; }
        public Airport DestinationAirport { get; set; }
        public Crew FlightCrew { get; set; }
        public DateTime ScheduledTakeoffTime { get; set; }
        public DateTime EstimatedTakeoffTime { get; set; }
        public DateTime ActualTakeoffTime { get; set; }
        public DateTime ScheduledTouchdownTime { get; set; }
        public DateTime EstimatedTouchdownTime { get; set; }
        public DateTime ActualTouchdownTime { get; set; }

        public Flight()
        {
            //TODO: make constructor
        }
    }
}
