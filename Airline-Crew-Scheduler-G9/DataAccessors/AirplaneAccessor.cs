using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Crew_Scheduler_G9.DataAccessors
{
    class AirplaneAccessor
    {

        //Todo: Create an Airplane insertion method
        public void InsertAirplane(BusinessObjects.Aircraft newAircraft /*, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create an Airplane retreival method
        public void RetrieveAirplane(/* query, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create an Airplane Update Method
        public void UpdateAirplane(BusinessObjects.Aircraft airplaneToUpdate/* query, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create an Airplane deletion Method
        public void DeleteAirplane(BusinessObjects.Aircraft deadAirplane/* query, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }
    }
}
