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
            try
            {
                var unqualifiedPilot = new Pilot("Sam", "Kirchner", false, false);
                var c = new Crew(unqualifiedPilot, unqualifiedPilot, new FlightAttendant(null, null));
                var airplane = new Nu150(123);
                airplane.QualifiedCrewCheck(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("This crew don't go with this plane");
            }
            
        }
    }
}
