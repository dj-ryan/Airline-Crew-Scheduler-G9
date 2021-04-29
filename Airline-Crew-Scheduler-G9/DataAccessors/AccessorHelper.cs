using System;
using System.Collections.Generic;
using System.Configuration;
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
    public static class AccessorHelper
    {
        public static MySqlConnection ConnectVal()
        {
            string myConnectionString = "Server=cse.unl.edu;Port=3306;Database=atimla;Uid=atimla;Pwd=ZxAfxIqxm1;";
            var conn = new MySql.Data.MySqlClient.MySqlConnection { ConnectionString = myConnectionString };
            return conn;
        }
    }
}
