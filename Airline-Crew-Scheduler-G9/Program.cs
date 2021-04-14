using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Crew_Scheduler_G9
{
    class Program
    {
        static void Main()
        {
            //TODO: write program
            Console.WriteLine("Hello World!");
            var yuh = new Nu150(100);
            Console.WriteLine(yuh.TravelSpeed);
            var unqualifiedPilot = new Pilot("Sam", "Kirchner", false, false);
            var oneManCrew = new Nu150Crew(unqualifiedPilot, unqualifiedPilot, null);
            
        }
    }
}
