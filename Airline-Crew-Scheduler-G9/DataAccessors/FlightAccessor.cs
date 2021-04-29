using System;
using System.Collections.Generic;
using Airline_Crew_Scheduler_G9.BusinessObjects;
using MySql.Data.MySqlClient;

/*
C# SQL CONNECTION GUIDE  -> https://www.youtube.com/watch?v=Et2khGnrIqc
#Stored Procedure Tutorial -> https://www.mysqltutorial.org/getting-started-with-mysql-stored-procedures.aspx
*/
//Todo: Implement Flight db CRUD methods:
namespace Airline_Crew_Scheduler_G9.DataAccessors
{

    public class FlightAccessor
    {

        //TODO: WIll need FlightTIme model accessor
        //Todo: Create db Flight Insertion method
        public void InsertFlight(Flight NewFlight)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create db Flight Retreival Method
        public List<Flight> RetrieveFlight()
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create db Flight complete update general method
        public void UpdateFlight()
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create db Flight special case Deletion method
        public void DeleteFlight(Flight deadFlight)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create db Upcoming Flight Retreival Method
        public List<Flight> RetrieveUpcomingFlights()
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create db ActualTakeoffTime update method
        public void UpdateActualTakeffTime(Flight flightToUpdate, DateTime ActualTakeoffTime)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create db Current Flight Retreival Method
        public List<Flight> RetrieveCurrentFlights()
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create db ActualTouchdownTime update method
        public void UpdateActualTouchdownTime(Flight flightToUpdate, DateTime ActualTouchdownTime)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create db Completed Flight Retreival Method
        public List<Flight> RetrieveCompletedFlights()
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

    }


}
