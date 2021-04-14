﻿using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Airline_Crew_Scheduler_G9
{
    public class Crew
    {
        public Pilot Captain { get; set; }

        public Pilot FirstOfficer { get; set; }

        public List<FlightAttendant> FlightAttendants { get; set; }

    }

    public class Gbr10Crew : Crew
    {
        public Gbr10Crew(Pilot captain, Pilot firstOfficer, FlightAttendant flightAttendant)
        {
            QualificationCheck(captain, firstOfficer);
            Captain = captain;
            FirstOfficer = firstOfficer;
            var attendants = new List<FlightAttendant>()
            {
                flightAttendant
            };
            FlightAttendants = attendants;
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
        public Nu150Crew(Pilot captain, Pilot firstOfficer, FlightAttendant flightAttendant)
        {
            QualificationCheck(captain, firstOfficer);
            Captain = captain;
            FirstOfficer = firstOfficer;
            var attendants = new List<FlightAttendant>()
            {
                flightAttendant
            };
            FlightAttendants = attendants;
        }
        public Nu150Crew(Pilot captain, Pilot firstOfficer, FlightAttendant flightAttendant1,
            FlightAttendant flightAttendant2)
        {
            QualificationCheck(captain, firstOfficer);
            Captain = captain;
            FirstOfficer = firstOfficer;
            var attendants = new List<FlightAttendant>()
            {
                flightAttendant1,
                flightAttendant2
            };
            FlightAttendants = attendants;
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