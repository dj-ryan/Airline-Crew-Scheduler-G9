using Airline_Crew_Scheduler_G9.BusinessObjects;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

/*
C# SQL CONNECTION GUIDE  -> https://www.youtube.com/watch?v=Et2khGnrIqc
#Stored Procedure Tutorial -> https://www.mysqltutorial.org/getting-started-with-mysql-stored-procedures.aspx

*/
namespace Airline_Crew_Scheduler_G9.DataAccessors
{
    class AircraftAccessor
    {
        public static object MessageBox { get; private set; }

        //Todo: Create an Aircraft insertion method
        //Not required  for project but could be implemented for more extensive features
        public void InsertAircraft(Aircraft newAircraft)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        public static List<Aircraft> RetrieveAircraft()
        {
            var outAircraft = new List<Aircraft>();
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT aircraftID, planeType, registrationString FROM Aircraft", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    var itemsArray = dataRow.ItemArray;
                    if (itemsArray[1] != null && string.Equals(itemsArray[1].ToString(), "NU-150", StringComparison.OrdinalIgnoreCase))
                    {
                        Aircraft nu = new Nu150(int.Parse(itemsArray[0].ToString()), itemsArray[2].ToString());
                        outAircraft.Add(nu);
                    } else if (itemsArray[1] != null && string.Equals(itemsArray[1].ToString(), "GBR-10", StringComparison.OrdinalIgnoreCase))
                    {
                        Aircraft gbr = new Gbr10(int.Parse(itemsArray[0].ToString()), itemsArray[2].ToString());
                        outAircraft.Add(gbr);
                    }

                }
                connection.Close();
            }

            return outAircraft;
        }

        public static Aircraft RetrieveAircraft(int aircraftID)
        {
            var outAircraft = new List<Aircraft>();
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT aircraftID, planeType, registrationString FROM Aircraft WHERE aircraftID = @aircraftID", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("aircraftID", aircraftID);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    var itemsArray = dataRow.ItemArray;
                    if (itemsArray[1] != null && string.Equals(itemsArray[1].ToString(), "NU-150", StringComparison.OrdinalIgnoreCase))
                    {
                        Aircraft nu = new Nu150(int.Parse(itemsArray[0].ToString()), itemsArray[2].ToString());
                        outAircraft.Add(nu);
                    }
                    else if (itemsArray[1] != null && string.Equals(itemsArray[1].ToString(), "GBR-10", StringComparison.OrdinalIgnoreCase))
                    {
                        Aircraft gbr = new Gbr10(int.Parse(itemsArray[0].ToString()), itemsArray[2].ToString());
                        outAircraft.Add(gbr);
                    }

                }
                connection.Close();
            }

            if (outAircraft.Count == 0)
            {
                return null;
            }
            return outAircraft[0];
        }

        public static List<Aircraft> RetrieveGbr10Aircraft()
        {
            var outAircraft = new List<Aircraft>();
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT aircraftID, planeType, registrationString FROM Aircraft WHERE planeType = 'GBR-10'", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    var itemsArray = dataRow.ItemArray;
                    Aircraft gbr = new Gbr10(int.Parse(itemsArray[0].ToString()), itemsArray[2].ToString());
                    outAircraft.Add(gbr);

                }
                connection.Close();
            }

            return outAircraft;
        }

        public static List<Aircraft> RetrieveNu150Aircraft()
        {
            var outAircraft = new List<Aircraft>();
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT aircraftID, planeType, registrationString FROM Aircraft WHERE planeType = 'NU-150'", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    var itemsArray = dataRow.ItemArray;
                    Aircraft nu = new Nu150(int.Parse(itemsArray[0].ToString()), itemsArray[2].ToString());
                    outAircraft.Add(nu);
                }
                connection.Close();
            }

            return outAircraft;
        }

        //Todo: Create an Aircraft Update Method
        //Not required  for project but could be implemented for more extensive features
        public void UpdateAircraft(Aircraft AircraftToUpdate)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }

        }

        //Todo: Create an Aircraft deletion Method
        //Not required  for project but could be implemented for more extensive features
        public void DeleteAircraft(Aircraft deadAircraft)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }
    }
}
