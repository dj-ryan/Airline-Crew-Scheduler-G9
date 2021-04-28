using Airline_Crew_Scheduler_G9.DataAccessors;
using System;
using System.Data;

//Todo: Implement Flight db CRUD methods:
namespace Airline_Crew_Scheduler_G9
{

    public class FlightAccessor
    {

        //TODO: WIll need FlightTIme model accessor
        //Todo: Create db Flight Insertion method
        public void InsertFlight(BusinessObjects.Flight NewFlight/*, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create db Flight Retreival Method
        public void RetrieveFlight(/* query, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create db Flight special case Deletion method
        public void DeleteFlight(BusinessObjects.Flight deadFlight/* query, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create db Upcoming Flight Retreival Method
        public void RetrieveUpcomingFlights(/* dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create db ActualTakeoffTime update method
        public void UpdateActualTakeffTime(BusinessObjects.Flight flightToUpdate, DateTime ActualTakeoffTime /* dbConnection  */ )
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create db Current Flight Retreival Method
        public void RetrieveCurrentFlights(/* dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create db ActualTouchdownTime update method
        public void UpdateActualTouchdownTime(BusinessObjects.Flight flightToUpdate, DateTime ActualTouchdownTime /* dbConnection  */ )
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create db Completed Flight Retreival Method
        public void RetrieveCompletedFlights(/* dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

    }


}
