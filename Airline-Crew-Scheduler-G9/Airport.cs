using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Crew_Scheduler_G9
{
    class Airport
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
