
//Todo: Create Airport db CRUD Methods, Add database connection strings and functionality

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Airline_Crew_Scheduler_G9.BusinessObjects;
using Dapper;
using MySql.Data.MySqlClient;

/*
C# SQL CONNECTION GUIDE  -> https://www.youtube.com/watch?v=Et2khGnrIqc
#Stored Procedure Tutorial -> https://www.mysqltutorial.org/getting-started-with-mysql-stored-procedures.aspx
*/
namespace Airline_Crew_Scheduler_G9.DataAccessors
{
    public class AirportAccessor
    {

        //Todo: db Airport insertion method
        public void InsertAirport(Airport newAirport)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: db Airport retrieval method
        public List<Airport> RetrieveAirport()
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: db Airport update method
        public void UpdateAirport(Airport airportToUpdate)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: db Airport deletion metho
        public void DeleteAirport(Airport deadAirport)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: db Gbr10StandByCrew update method
        public void UpdateGbr10StandByCrew(Airport airportToUpdate, Gbr10Crew freshCrew)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: db Nu150StandByCrew update method
        public void UpdateNu150StandByCrew(Airport airportToUpdate , Nu150Crew freshCrew)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }
    }
}
