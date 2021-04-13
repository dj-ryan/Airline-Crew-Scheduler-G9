using System.Collections.Generic;
using System.Dynamic;

namespace Airline_Crew_Scheduler_G9
{
    public class Crew
    {
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
    }
}