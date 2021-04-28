
//Todo: Create Airport db CRUD Methods, Add database connection strings and functionality
using Airline_Crew_Scheduler_G9.BusinessObjects;
using Airline_Crew_Scheduler_G9.DataAccessors;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
/*
C# SQL CONNECTION GUIDE  -> https://www.youtube.com/watch?v=Et2khGnrIqc
#Stored Procedure Tutorial -> https://www.mysqltutorial.org/getting-started-with-mysql-stored-procedures.aspx
*/
namespace Airline_Crew_Scheduler_G9
{
    public class AirportAccessor
    {

        //Todo: db Airport insertion method
        public void InsertAirport(Airport newAirport)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: db Airport retrieval method
        public List<Airport> RetrieveAirport()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                var AirportList = connection.Query<Airport>("/*StoredProcdedureCall*/").ToList();
                return AirportList;
            }
        }

        //Todo: db Airport update method
        public void UpdateAirport(Airport airportToUpdate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: db Airport deletion metho
        public void DeleteAirport(Airport deadAirport)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: db Gbr10StandByCrew update method
        public void UpdateGbr10StandByCrew(Airport airportToUpdate, Gbr10Crew freshCrew)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: db Nu150StandByCrew update method
        public void UpdateNu150StandByCrew(Airport airportToUpdate , Nu150Crew freshCrew)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }
    }
}
