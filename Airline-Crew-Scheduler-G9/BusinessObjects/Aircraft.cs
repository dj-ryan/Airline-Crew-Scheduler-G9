using System;

namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public abstract class Aircraft
    {
        public int RegistrationNumber { get; set; }
        public int TravelSpeed { get; set; } = 500;
        public int Capacity { get; set; }

        protected Aircraft(int registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }
        public abstract void QualifiedCrewCheck(Crew crew); //checks whether a crew is qualified for the aircraft
    }

    public class Gbr10 : Aircraft
    {
        public Gbr10(int registrationNumber) : base(registrationNumber)
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
        public Nu150(int registrationNumber) : base(registrationNumber)
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
