using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Crew_Scheduler_G9.DataAccessors
{
    class CrewAccessor
    {
        //Todo: Create an Crew insertion method
        public void InsertCrew(BusinessObjects.Crew newCrew /*, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create an Crew retreival method
        public void RetrieveCrew(/* query, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create an Crew Captain Update Method

        public void UpdateCrew(BusinessObjects.Crew crewToUpdate /*dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create an Crew deletion Method


        public void DeleteCrew(BusinessObjects.Crew deadCrew /*dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }
    }
}
