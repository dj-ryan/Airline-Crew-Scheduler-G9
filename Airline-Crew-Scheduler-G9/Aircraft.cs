using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Crew_Scheduler_G9
{
    class Aircraft
    {
        public int RegistrationNumber { get; set; }
        public int TravelSpeed { get; set; } = 500;
        public int Capacity { get; set; }

    }

    class Gbr10 : Aircraft
    {
        public Gbr10(int registrationNumber)
        {
            RegistrationNumber = registrationNumber;
            Capacity = 45;
        }

    }

    class Nu150 : Aircraft
    {
        public Nu150(int registrationNumber)
        {
            RegistrationNumber = registrationNumber;
            Capacity = 75;
        } 

    }
}
