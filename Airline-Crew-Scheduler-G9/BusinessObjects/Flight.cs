using System;

namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Flight
    {
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

        public Flight(int FlightNumber,
                      Aircraft FlightAircraft,
                      Airport OriginAirport, Airport DestinationAirport,
                      Crew FlightCrew,
                      DateTime ScheduledTakeoffTime, DateTime EstimatedTakeoffTime, DateTime ActualTakeoffTime,
                      DateTime ScheduledTouchDownTime, DateTime EstimatedTouchDownTime, DateTime ActualTouchdownTime)
        {

        }
    }
}
