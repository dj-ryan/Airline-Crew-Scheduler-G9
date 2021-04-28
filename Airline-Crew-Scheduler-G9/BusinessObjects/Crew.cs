using System;
using System.Collections.Generic;

namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Crew
    {
        public int CrewId { get; set; }
        public Pilot Captain { get; set; }

        public Pilot FirstOfficer { get; set; }

        public List<FlightAttendant> FlightAttendants { get; set; }

        public Crew(Pilot captain, Pilot firstOfficer, FlightAttendant flightAttendant)
        {
            Captain = captain;
            FirstOfficer = firstOfficer;
            var attendants = new List<FlightAttendant>()
            {
                flightAttendant
            };
            FlightAttendants = attendants;
        }
        public Crew(Pilot captain, Pilot firstOfficer, FlightAttendant flightAttendant1,
            FlightAttendant flightAttendant2)
        {
            Captain = captain;
            FirstOfficer = firstOfficer;
            var attendants = new List<FlightAttendant>()
            {
                flightAttendant1,
                flightAttendant2
            };
            FlightAttendants = attendants;
        }

        public Crew(Pilot captain, Pilot firstOfficer, List<FlightAttendant> flightAttendants)
        {
            Captain = captain;
            FirstOfficer = firstOfficer;
            FlightAttendants = flightAttendants;
        }
    }

    public class Gbr10Crew : Crew
    {
        public Gbr10Crew(Pilot captain, Pilot firstOfficer, FlightAttendant flightAttendant) : base(captain, firstOfficer, flightAttendant)
        {
            QualificationCheck(captain, firstOfficer);
        }
        public Gbr10Crew(Pilot captain, Pilot firstOfficer, List<FlightAttendant> flightAttendants) : base(captain, firstOfficer, flightAttendants)
        {
            QualificationCheck(captain, firstOfficer);
        }

        private static void QualificationCheck(Pilot captain, Pilot firstOfficer)
        {
            if (captain.QualifiedForGbr10 == false || firstOfficer.QualifiedForGbr10 == false)
            {
                throw new ArgumentException("Crew not Qualified");
            }
        }
    }

    public class Nu150Crew : Crew
    {
        public Nu150Crew(Pilot captain, Pilot firstOfficer, FlightAttendant flightAttendant) : base(captain, firstOfficer, flightAttendant)
        {
            QualificationCheck(captain, firstOfficer);
            
        }
        public Nu150Crew(Pilot captain, Pilot firstOfficer, FlightAttendant flightAttendant1,
            FlightAttendant flightAttendant2) : base(captain, firstOfficer, flightAttendant1, flightAttendant2)
        {
            QualificationCheck(captain, firstOfficer);
            
        }
        public Nu150Crew(Pilot captain, Pilot firstOfficer, List<FlightAttendant> flightAttendants) : base(captain, firstOfficer, flightAttendants)
        {
            QualificationCheck(captain, firstOfficer);
        }

        private static void QualificationCheck(Pilot captain, Pilot firstOfficer)
        {
            if (captain.QualifiedForNu150 == false || firstOfficer.QualifiedForNu150 == false)
            {
                throw new ArgumentException("Crew not Qualified");
            }
        }
    }
}