
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
        public void InsertAirport(Airport newAirport)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        public static List<Airport> RetrieveAirport()
        {
            var outAirports = new List<Airport>();
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT airportID, city, state FROM Airport", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    var itemsArray = dataRow.ItemArray;
                    Airport ap = new Airport(int.Parse(itemsArray[0].ToString()), itemsArray[1].ToString(), itemsArray[2].ToString());
                    outAirports.Add(ap);
                }
                connection.Close();
            }

            return outAirports;
        }
        
        public static Airport RetrieveAirport(string city, string state)
        {
            var outAirports = new List<Airport>();
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT airportID, city, state FROM Airport WHERE city = @city AND state = @state", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("city", city);
                cmd.Parameters.AddWithValue("state", state);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    var itemsArray = dataRow.ItemArray;
                    Airport ap = new Airport(int.Parse(itemsArray[0].ToString()), itemsArray[1].ToString(), itemsArray[2].ToString());
                    outAirports.Add(ap);
                }
                connection.Close();
            }

            if (outAirports.Count == 0)
            {
                return null;
            }
            return outAirports[0];
            
        }

        public static Airport RetrieveAirport(int airportID)
        {
            var outAirports = new List<Airport>();
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT airportID, city, state FROM Airport WHERE airportID = @airportID", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("airportID", airportID);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    var itemsArray = dataRow.ItemArray;
                    Airport ap = new Airport(int.Parse(itemsArray[0].ToString()), itemsArray[1].ToString(), itemsArray[2].ToString());
                    outAirports.Add(ap);
                }
                connection.Close();
            }

            if (outAirports.Count == 0)
            {
                return null;
            }
            return outAirports[0];

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
