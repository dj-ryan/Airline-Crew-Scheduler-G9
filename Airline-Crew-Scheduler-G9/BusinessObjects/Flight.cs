using System;

namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Flight
    {
        public int FlightNumber { get; set; }
        public Aircraft FlightAircraft { get; set; }
        public Crew FlightCrew { get; set; }
        public Airport OriginAirport { get; set; }
        public Airport DestinationAirport { get; set; }
        public FlightTime Flightlog { get; set; }
        public int PassengerCount { get; set; }

        public Flight(int flightNumber, Aircraft flightAircraft, Crew flightCrew, Airport originAirport, Airport destinationAirport, FlightTime flightlog, int passengerCount)
        {
            FlightNumber = flightNumber;
            FlightAircraft = flightAircraft;
            FlightCrew = flightCrew;
            OriginAirport = originAirport;
            DestinationAirport = destinationAirport;
            Flightlog = flightlog;
            PassengerCount = passengerCount;
        }
    }
}