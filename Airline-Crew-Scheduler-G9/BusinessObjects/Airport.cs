namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Nu150StandbyCrewID { get; set; }
        public int Gbr10StandbyCrewID { get; set; }
        public int Nu150MainCrewID { get; set; }
        public int Gbr10MainCrewID { get; set; }

        public Airport(int id, string city, string state, int Nu150Main, int Gbr10Main, int Nu150Standby, int Gbr10Standby)
        {
            AirportId = id;
            City = city;
            State = state;
            Nu150StandbyCrewID = Nu150Standby;
            Gbr10StandbyCrewID = Gbr10Standby;
            Nu150MainCrewID = Nu150Main;
            Gbr10MainCrewID = Gbr10Main;
        }

        public override string ToString()
        {
            return City + ", " + State;
        }

    }
}
