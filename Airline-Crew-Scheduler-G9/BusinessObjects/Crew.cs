using System;
using System.Collections.Generic;
using Airline_Crew_Scheduler_G9.DataAccessors;
namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Crew
    {
        public int CrewId { get; set; }
        public int Captain { get; set; }

        public int FirstOfficer { get; set; }
        public int FlightAttendant1 { get; set; }
        public int FlightAttendant2 { get; set; }

        public List<Employee> FlightAttendants { get; set; }

        public Crew(int captain, int firstOfficer, int flightAttendant)
        {
            Captain = captain;
            FirstOfficer = firstOfficer;
            FlightAttendant1 = flightAttendant;
        }
        public Crew(int captain, int firstOfficer, int flightAttendant1,
            int flightAttendant2)
        {
            Captain = captain;
            FirstOfficer = firstOfficer;
            FlightAttendant1 = flightAttendant1;
            FlightAttendant2 = flightAttendant2;
        }

        public Crew(int captain, int firstOfficer, List<Employee> flightAttendants)
        {
            Captain = captain;
            FirstOfficer = firstOfficer;
            FlightAttendants = flightAttendants;
        }

        public override string ToString()
        {
            return "\t\t\tCaptain: " + Captain + "\n\t\t\tFirst Officer: " + FirstOfficer;
        }
    }

    public class Gbr10Crew : Crew
    {
        public Gbr10Crew(int captain, int firstOfficer, int flightAttendant) : base(captain, firstOfficer, flightAttendant)
        {
            QualificationCheck(captain, firstOfficer);
        }
        public Gbr10Crew(int captain, int firstOfficer, List<Employee> flightAttendants) : base(captain, firstOfficer, flightAttendants)
        {
            QualificationCheck(captain, firstOfficer);
        }

        private static void QualificationCheck(int captain, int firstOfficer)
        {
            var cap = EmployeeAccessor.RetrieveEmployee(captain);
            var fo = EmployeeAccessor.RetrieveEmployee(firstOfficer);
            if (cap.Gbr10Certification == false || fo.Gbr10Certification == false)
            {
                throw new ArgumentException("Crew not Qualified");
            }
        }
    }

    public class Nu150Crew : Crew
    {
        public Nu150Crew(int captain, int firstOfficer, int flightAttendant) : base(captain, firstOfficer, flightAttendant)
        {
            QualificationCheck(captain, firstOfficer);

        }
        public Nu150Crew(int captain, int firstOfficer, int flightAttendant1,
            int flightAttendant2) : base(captain, firstOfficer, flightAttendant1, flightAttendant2)
        {
            QualificationCheck(captain, firstOfficer);

        }
        public Nu150Crew(int captain, int firstOfficer, List<Employee> flightAttendants) : base(captain, firstOfficer, flightAttendants)
        {
           QualificationCheck(captain, firstOfficer);
        }

        private static void QualificationCheck(int captain, int firstOfficer)
        {
            var cap = EmployeeAccessor.RetrieveEmployee(captain);
            var fo = EmployeeAccessor.RetrieveEmployee(firstOfficer);
            if (cap.Nu150Certification == false || fo.Nu150Certification == false)
            {
                throw new ArgumentException("Crew not Qualified");
            }
        }

    }
}