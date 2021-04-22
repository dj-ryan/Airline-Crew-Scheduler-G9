namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Airport
    {
        //TODO: add location
        public int Id { get; set; }
        public string Name { get; set; }

        public Nu150Crew Nu150StandbyCrew { get; set; }

        public Gbr10Crew Gbr10StandbyCrew { get; set; }

        public Airport(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
    }
}
