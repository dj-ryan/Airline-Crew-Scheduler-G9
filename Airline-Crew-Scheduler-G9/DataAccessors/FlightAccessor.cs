using Airline_Crew_Scheduler_G9.BusinessObjects;
using Airline_Crew_Scheduler_G9.DataAccessors;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
/*
C# SQL CONNECTION GUIDE  -> https://www.youtube.com/watch?v=Et2khGnrIqc
*/
//Todo: Implement Flight db CRUD methods:
namespace Airline_Crew_Scheduler_G9
{

    public class FlightAccessor
    {

        //TODO: WIll need FlightTIme model accessor
        //Todo: Create db Flight Insertion method
        public void InsertFlight(Flight NewFlight)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: Create db Flight Retreival Method
        public List<Flight> RetrieveFlight()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                var AllList = connection.Query<Flight>("/*StoredProcdedureCall*/").ToList();
                return AllList;
            }
        }

        //Todo: Create db Flight complete update method
        public void UpdateFlight()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: Create db Flight special case Deletion method
        public void DeleteFlight(Flight deadFlight)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: Create db Upcoming Flight Retreival Method
        public List<Flight> RetrieveUpcomingFlights()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                var UpcomingList = connection.Query<Flight>("/*StoredProcdedureCall*/").ToList();
                return UpcomingList;
            }
        }

        //Todo: Create db ActualTakeoffTime update method
        public void UpdateActualTakeffTime(Flight flightToUpdate, DateTime ActualTakeoffTime)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: Create db Current Flight Retreival Method
        public List<Flight> RetrieveCurrentFlights()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                var CurrentList = connection.Query<Flight>("/*StoredProcdedureCall*/").ToList();
                return CurrentList;
            }
        }

        //Todo: Create db ActualTouchdownTime update method
        public void UpdateActualTouchdownTime(Flight flightToUpdate, DateTime ActualTouchdownTime)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: Create db Completed Flight Retreival Method
        public List<Flight> RetrieveCompletedFlights()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                var CompletedList = connection.Query<Flight>("/*StoredProcdedureCall*/").ToList();
                return CompletedList;
            }
        }

    }


}
