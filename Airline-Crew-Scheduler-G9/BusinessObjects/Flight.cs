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
        public FlightTime Flightlog { get; set; }

        Flight(int flightNumber, Aircraft flightAircraft, Airport originAirport, Airport destinationAirport, FlightTime flightlog)
        {
            FlightNumber = flightNumber;
            FlightAircraft = flightAircraft;
            OriginAirport = originAirport;
            DestinationAirport = destinationAirport;
            Flightlog = flightlog;
        }
    }
}
