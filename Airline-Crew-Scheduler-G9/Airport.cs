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

        public Crew Nu150StandbyCrew { get; set; }

        public Crew Gbr10StandbyCrew { get; set; }

        public Airport(string name)
        {
            Name = name;
        }
        public void SetNu150Crew(Crew crew)
        {
            if (crew.Captain.QualifiedForNu150 == false || crew.FirstOfficer.QualifiedForNu150 == false)
            {
                throw new ArgumentException("Crew not Qualified", nameof(crew));
            }

            Nu150StandbyCrew = crew;
        }

        public void SetGbr10Crew(Crew crew)
        {
            if (crew.Captain.QualifiedForGbr10 == false || crew.FirstOfficer.QualifiedForGbr10 == false)
            {
                throw new ArgumentException("Crew not Qualified",nameof(crew));
            }

            Gbr10StandbyCrew = crew;
        }
    }
}
