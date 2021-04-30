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

                    Employee captain = EmployeeAccessor.RetrieveEmployee((int) itemsArray[1]);
                    Employee firstOfficer = EmployeeAccessor.RetrieveEmployee((int) itemsArray[2]);
                    var flightAttendants = new List<FlightAttendant>();

                    Employee flightAttendant1 = EmployeeAccessor.RetrieveEmployee((int)itemsArray[3]);
                    if (flightAttendant1 != null)
                    {
                        flightAttendants.Add((FlightAttendant) flightAttendant1);
                    }

                    Employee flightAttendant2 = EmployeeAccessor.RetrieveEmployee((int)itemsArray[3]);
                    if (flightAttendant2 != null)
                    {
                        flightAttendants.Add((FlightAttendant) flightAttendant2);
                    }

                    Crew c = new Crew((Pilot) captain, (Pilot) firstOfficer, flightAttendants);
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

        public List<Crew> RetrieveCrew()
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
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
