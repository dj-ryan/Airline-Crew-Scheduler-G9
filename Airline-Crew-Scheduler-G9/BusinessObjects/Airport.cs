namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string Name { get; set; }
        //TODO: Split name into state and city field
        //TODO: Split name into state and city field

        public Nu150Crew Nu150StandbyCrew { get; set; }
        public Gbr10Crew Gbr10StandbyCrew { get; set; }

        public Airport(int id, string name)
        {
            AirportId = id;
            Name = name;
        }
        
    }
}
