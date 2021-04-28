
//Todo: Create Airport db CRUD Methods, Add database connection strings and functionality
using Airline_Crew_Scheduler_G9.DataAccessors;
using System;
using System.Data;

namespace Airline_Crew_Scheduler_G9
{
    public class AirportAccessor
    {

        //Todo: db Airport insertion method
        public void InsertAirport(BusinessObjects.Airport newAirport/*, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: db Airport retrieval method
        public void RetrieveAirport(/* query, dbConnection  */ )
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: db Airport update method
        public void UpdateAirport(BusinessObjects.Airport airportToUpdate/* dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: db Airport deletion metho
        public void DeleteAirport(BusinessObjects.Airport deadAirport/* dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: db Gbr10StandByCrew update method
        public void UpdateGbr10StandByCrew(BusinessObjects.Airport airportToUpdate, BusinessObjects.Gbr10Crew freshCrew/*, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: db Nu150StandByCrew update method
        public void UpdateNu150StandByCrew(BusinessObjects.Airport airportToUpdate , BusinessObjects.Nu150Crew freshCrew/*, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }
    }
}
