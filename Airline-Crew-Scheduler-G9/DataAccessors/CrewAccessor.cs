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
    class CrewAccessor
    {
        //Todo: Create an Crew insertion method
        public void InsertCrew(Crew newCrew)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: Create an Crew retreival method
        public List<Crew> RetrieveCrew()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                var CrewList = connection.Query<Crew>("/*StoredProcdedureCall*/").ToList();
                return CrewList;
            }
        }

        //Todo: Create an Crew Captain Update Method
        public void UpdateCrew(Crew crewToUpdate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: Create an Crew deletion Method
        public void DeleteCrew(Crew deadCrew)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }
    }
}
