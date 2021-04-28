using Airline_Crew_Scheduler_G9.BusinessObjects;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
C# SQL CONNECTION GUIDE  -> https://www.youtube.com/watch?v=Et2khGnrIqc
*/
namespace Airline_Crew_Scheduler_G9.DataAccessors
{
    class AirplaneAccessor
    {

        //Todo: Create an Airplane insertion method
        public void InsertAirplane(Aircraft newAircraft)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: Create an Airplane retreival method
        public List<Aircraft> RetrieveAirplane()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                var AircraftList = connection.Query<Aircraft>("/*StoredProcdedureCall*/").ToList();
                return AircraftList;
            }
        }

        //Todo: Create an Airplane Update Method
        public void UpdateAirplane(Aircraft airplaneToUpdate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: Create an Airplane deletion Method
        public void DeleteAirplane(Aircraft deadAirplane)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }
    }
}
