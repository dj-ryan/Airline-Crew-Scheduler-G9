using System;

namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public abstract class Aircraft
    {
        public string RegistrationString { get; set; }
        public int TravelSpeed { get; set; } = 500;
        public int Capacity { get; set; }

        protected Aircraft(string registrationString)
        {
            RegistrationString = registrationString;
        }
        public abstract void QualifiedCrewCheck(Crew crew); //checks whether a crew is qualified for the aircraft
    }

    public class Gbr10 : Aircraft
    {
        public Gbr10(string registrationString) : base(registrationString)
        {
            Capacity = 45;
        }

        public override void QualifiedCrewCheck(Crew crew)
        {
            try
            {
                var gCrew = new Gbr10Crew(crew.Captain, crew.FirstOfficer, crew.FlightAttendants);
            }
            catch
            {
                throw new ArgumentException("This crew is not qualified for this aircraft.");
            }
        }
    }

    public class Nu150 : Aircraft
    {
        public Nu150(string registrationString) : base(registrationString)
        {
            Capacity = 75;
        }

        public override void QualifiedCrewCheck(Crew crew)
        {
            try
            {
                var nCrew = new Nu150Crew(crew.Captain, crew.FirstOfficer, crew.FlightAttendants);
            }
            catch 
            {
                throw new ArgumentException("This crew is not qualified for this aircraft.");
            }
        }
    }
}
