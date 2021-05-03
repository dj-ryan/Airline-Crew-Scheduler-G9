using Airline_Crew_Scheduler_G9.BusinessObjects;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/*
C# SQL CONNECTION GUIDE  -> https://www.youtube.com/watch?v=Et2khGnrIqc
#Stored Procedure Tutorial -> https://www.mysqltutorial.org/getting-started-with-mysql-stored-procedures.aspx
*/
namespace Airline_Crew_Scheduler_G9.DataAccessors
{
    class CrewAccessor
    {
        //Todo: Create an Crew insertion method
        public void InsertCrew(Crew newCrew)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        public static Crew RetrieveCrew(int crewID)
        {
            var outCrews = new List<Crew>();
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT crewID, captain, firstOfficer, flightAttendant1, flightAttendant2 FROM Crew WHERE crewID = @crewID", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("crewID", crewID);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    var itemsArray = dataRow.ItemArray;
                    Crew c;;
                    int captain = int.Parse(itemsArray[1].ToString());
                    int firstOfficer = int.Parse(itemsArray[2].ToString());
                    int flightAttendant1 = int.Parse(itemsArray[3].ToString());
                    int flightAttendant2 = int.Parse(itemsArray[4].ToString());
                    if (flightAttendant2 != 0)
                    {
                        c = new Crew(captain, firstOfficer, flightAttendant1, flightAttendant2);
                    }
                    else
                    {
                        c = new Crew(captain, firstOfficer, flightAttendant1);
                    }
                    outCrews.Add(c);

                }
                connection.Close();
            }

            if (outCrews.Count == 0)
            {
                return null;
            }
            return outCrews[0];
        }

        //Todo: Create an Crew Captain Update Method
        public void UpdateCrew(Crew crewToUpdate)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create an Crew deletion Method
        public void DeleteCrew(Crew deadCrew)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }
    }
}
