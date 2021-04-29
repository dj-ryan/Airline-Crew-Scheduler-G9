//Todo: Create Employee db CRUD methods

using System;
using System.Collections.Generic;
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
