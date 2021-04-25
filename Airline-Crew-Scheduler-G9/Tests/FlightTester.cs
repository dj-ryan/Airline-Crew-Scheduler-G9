using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Crew_Scheduler_G9.BusinessObjects;

namespace Airline_Crew_Scheduler_G9.Tests
{
    //TODO: Implement Method Testers, the arguments are just what the methods rely on in the other classes, at this moment
    //They still need to be changed to whatever the relevent tester needs, feel free to make any edits for the better
    public class FlightTester

    {

        //TODO: Flight constructor must be implemented before this test can be made, Just test if instantiation method is valid
        public void FlightTest(int x)
        {

        }

        //TODO: SQL database Method Tests Below, SQL database models must be implemented first
        public void InsertFlightTester(Flight NewFlight/*, dbConnection  */)
        {

        }

        public void RetrieveFlightTester(/* query, dbConnection  */)
        {

        }

        public void DeleteFlightTester(int FlightNumber/* query, dbConnection  */)
        {

        }

        public void RetrieveUpcomingFlightsTester(/* dbConnection  */)
        {

        }

        public void UpdateActualTakeffTimeTester(int FlightNumber, DateTime ActualTakeoffTime /* dbConnection  */ )
        {

        }

        public void RetrieveCurrentFlightsTester(/* dbConnection  */)
        {

        }

        public void UpdateActualTouchdownTimeTester(int FlightNumber, DateTime ActualTouchdownTime /* dbConnection  */ )
        {

        }

        public void RetrieveCompletedFlightsTester(/* dbConnection  */)
        {

        }
    }

}
