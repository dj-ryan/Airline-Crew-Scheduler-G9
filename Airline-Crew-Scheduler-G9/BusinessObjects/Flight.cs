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

        public Flight()
        {
            //TODO: make constructor
        }
    }
}
