using System;
using System.Collections.Generic;
using System.Data;
using Airline_Crew_Scheduler_G9.BusinessObjects;
using MySql.Data.MySqlClient;

/*
C# SQL CONNECTION GUIDE  -> https://www.youtube.com/watch?v=Et2khGnrIqc
#Stored Procedure Tutorial -> https://www.mysqltutorial.org/getting-started-with-mysql-stored-procedures.aspx
*/
//Todo: Implement Flight db CRUD methods:
namespace Airline_Crew_Scheduler_G9.DataAccessors
{

    public class FlightAccessor
    {

        //TODO: WIll need FlightTIme model accessor
        //Todo: Create db Flight Insertion method
        public void InsertFlight(Flight NewFlight)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create db Flight Retreival Method
        public List<Flight> RetrieveFlight()
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        public static List<Flight> RetrieveUpcomingFlights()
        {
            var outFlights = new List<Flight>();
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT flightID, aircraft, crewList, origin, destination, flightTime, passengerCount FROM Flight WHERE flightStatus = 'upcoming'", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    var itemsArray = dataRow.ItemArray;
                    Aircraft aircraft = AircraftAccessor.RetrieveAircraft((int) itemsArray[1]);
                    Crew crew = CrewAccessor.RetrieveCrew((int) itemsArray[2]);
                    Airport origin = AirportAccessor.RetrieveAirport((int) itemsArray[3]);
                    Airport destination = AirportAccessor.RetrieveAirport((int)itemsArray[4]);
                    FlightTime flightTime = FlightTimeAccessor.RetrieveFlightTime((int) itemsArray[5]);

                    outFlights.Add(new Flight((int) itemsArray[0], aircraft, crew, origin, destination, flightTime, (int)itemsArray[6]));

                }
                connection.Close();
            }

            if (outFlights.Count == 0)
            {
                return null;
            }
            return outFlights;
        }

        //Todo: Create db Flight complete update general method
        public void UpdateFlight()
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create db Flight special case Deletion method
        public void DeleteFlight(Flight deadFlight)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }


        //Todo: Create db ActualTakeoffTime update method
        public void UpdateActualTakeffTime(Flight flightToUpdate, DateTime ActualTakeoffTime)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create db Current Flight Retreival Method
        public List<Flight> RetrieveCurrentFlights()
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create db ActualTouchdownTime update method
        public void UpdateActualTouchdownTime(Flight flightToUpdate, DateTime ActualTouchdownTime)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create db Completed Flight Retreival Method
        public List<Flight> RetrieveCompletedFlights()
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

    }


}
