namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Airport
    {
        //TODO: add location
        public string Name { get; set; }

        public Nu150Crew Nu150StandbyCrew { get; set; }

        public Gbr10Crew Gbr10StandbyCrew { get; set; }

        public Airport(string name)
        {
            Name = name;
        }
        
    }
}
