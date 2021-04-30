//Todo: Create Employee db CRUD methods

using System;
using System.Collections.Generic;
using System.Data;
using Airline_Crew_Scheduler_G9.BusinessObjects;
using MySql.Data.MySqlClient;

/*
C# SQL CONNECTION GUIDE  -> https://www.youtube.com/watch?v=Et2khGnrIqc
#Stored Procedure Tutorial -> https://www.mysqltutorial.org/getting-started-with-mysql-stored-procedures.aspx
*/
namespace Airline_Crew_Scheduler_G9.DataAccessors
{

    public class EmployeeAccessor
    {
        //Todo: Create an Employee insertion method
        public void InsertEmployee(Employee newEmployee)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create an Employee retreival method
        public List<Employee> RetrieveEmployee()
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        public static Employee RetrieveEmployee(int employeeID)
        {
            var outEmployees = new List<Employee>();
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT employeeID, firstName, lastName, isPilot, gbr10Certification, nu150Certification FROM Employee WHERE employeeID = @employeeID", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("employeeID", employeeID);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    var itemsArray = dataRow.ItemArray;
                    if ((bool) itemsArray[3])
                    {
                        Employee e = new Pilot((int) itemsArray[0], (string) itemsArray[1], (string)itemsArray[2], (bool)itemsArray[4], (bool)itemsArray[5]);
                        outEmployees.Add(e);
                    }
                    else
                    {
                        Employee e = new FlightAttendant((int) itemsArray[0], (string) itemsArray[1], (string) itemsArray[2]);
                        outEmployees.Add(e);
                    }

                }
                connection.Close();
            }

            if (outEmployees.Count == 0)
            {
                return null;
            }
            return outEmployees[0];
        }
        //Todo: Create an Employee Update Method

        public void UpdateEmployee(Employee employeeToUpdate)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }

        //Todo: Create an Employee deletion Method


        public void DeleteEmployee(Employee deadEmployee)
        {
            using (MySqlConnection connection = AccessorHelper.ConnectVal())
            {
                throw new NotImplementedException();
            }
        }
    }


}
