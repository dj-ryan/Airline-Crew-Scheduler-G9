using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Crew_Scheduler_G9.BusinessObjects;
using MySql.Data.MySqlClient;

namespace Airline_Crew_Scheduler_G9.DataAccessors
{
    class FlightTimeAccessor
    {
        public static FlightTime RetrieveFlightTime(int timeID)
        {
            var outFlightTime = new List<FlightTime>();
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT timeID, scheduledTakeoff, estimatedTakeoff, actualTakeoff, scheduledArrival, estimatedArrival, actualArrival FROM FlightTime WHERE timeID = @timeID", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("timeID", timeID);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    var itemsArray = dataRow.ItemArray;
                    //may not work vvv
                    FlightTime d = new FlightTime((int)itemsArray[0], DateTime.Parse((string) itemsArray[1]));
                    outFlightTime.Add(d);
                }
                connection.Close();
            }

            if (outFlightTime.Count == 0)
            {
                return null;
            }
            return outFlightTime[0];
        }
    }
}
