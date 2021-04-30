namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Nu150Crew Nu150StandbyCrew { get; set; }
        public Gbr10Crew Gbr10StandbyCrew { get; set; }

        public Airport(int id, string city, string state)
        {
            AirportId = id;
            City = city;
            State = state;
        }

        public override string ToString()
        {
            return City + ", " + State;
        }

    }
}
