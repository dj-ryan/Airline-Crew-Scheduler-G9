using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
C# SQL CONNECTION GUIDE  -> https://www.youtube.com/watch?v=Et2khGnrIqc
*/
namespace Airline_Crew_Scheduler_G9.DataAccessors
{
    public static class AccessorHelper
    {
        public static string ConnectVal(string dbConnectString)
        {
            return ConfigurationManager.ConnectionStrings[dbConnectString].ConnectionString;
        }
    }
}
