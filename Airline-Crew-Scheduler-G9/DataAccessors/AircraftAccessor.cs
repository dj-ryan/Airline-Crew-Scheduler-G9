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
        public void InsertAircraft(Aircraft newAircraft)
        {   
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: Create an Aircraft retreival method
        public static DataTable RetrieveAircraft()
        {
            MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "Server=cse.unl.edu;Port=3306;Database=atimla;Uid=atimla;Pwd=ZxAfxIqxm1;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            //Aircraft a1 = new Aircraft();

            using (MySqlConnection connection = conn)
            {
                
                //IEnumerable<string> aircraftID = connection.Query<string>("SELECT planeType FROM Airplane WHERE airplaneID = '1'");
                MySqlCommand cmd = new MySqlCommand("SELECT planeType FROM Airplane WHERE airplaneID = '1'", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            conn.Close();
        }

        //Todo: Create an Aircraft Update Method
        public void UpdateAircraft(Aircraft AircraftToUpdate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: Create an Aircraft deletion Method
        public void DeleteAircraft(Aircraft deadAircraft)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }
    }
}
