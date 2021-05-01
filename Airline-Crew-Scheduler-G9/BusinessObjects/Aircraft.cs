using System;

namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public abstract class Aircraft
    {
        public int airplaneID { get; set;}
        public string planeType { get; set; }
        public string registrationNo { get; set; }
        public int speed { get; set; } = 500;
        public int seats { get; set; }

        protected Aircraft(int airplaneID, string registrationNo)
        {
            this.airplaneID = airplaneID;
            this.registrationNo = registrationNo;
        }
        public abstract void QualifiedCrewCheck(Crew crew); //checks whether a crew is qualified for the aircraft
    }

    public class Gbr10 : Aircraft
    {
        public Gbr10(int airplaneID, string registrationNo) : base(airplaneID, registrationNo)
        {
            seats = 45;
            planeType = "GBR-10";
        }

        public override void QualifiedCrewCheck(Crew crew)
        {
            try
            {
                var gCrew = new Crew(crew.Captain, crew.FirstOfficer, crew.FlightAttendants);
            }
            catch
            {
                throw new ArgumentException("This crew is not qualified for this aircraft.");
            }
        }
    }

    public class Nu150 : Aircraft
    {
        public Nu150(int airplaneID, string registrationNo) : base(airplaneID, registrationNo)
        {
            seats = 75;
            planeType = "NU-150";
        }

        public override void QualifiedCrewCheck(Crew crew)
        {
            try
            {
                var nCrew = new Crew(crew.Captain, crew.FirstOfficer, crew.FlightAttendants);
            }
            catch
            {
                throw new ArgumentException("This crew is not qualified for this aircraft.");
            }
        }
    }
}
