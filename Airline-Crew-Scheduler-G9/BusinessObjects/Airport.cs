namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string Name { get; set; }
        public Nu150Crew Nu150StandbyCrew { get; set; }
        public Gbr10Crew Gbr10StandbyCrew { get; set; }

        //Need to add Standby Crew to Airport Constructor or make an interface right?
        public Airport(int id, string name)
        {
            AirportId = id;
            Name = name;
        }
        
    }
}
