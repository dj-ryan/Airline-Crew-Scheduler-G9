//Todo: Create Employee db CRUD methods
using Airline_Crew_Scheduler_G9.BusinessObjects;
using System.Collections;
using System.Collections.Generic;
using Dapper;
using System;
using Airline_Crew_Scheduler_G9.DataAccessors;
using System.Data;
using System.Linq;
/*
C# SQL CONNECTION GUIDE  -> https://www.youtube.com/watch?v=Et2khGnrIqc
#Stored Procedure Tutorial -> https://www.mysqltutorial.org/getting-started-with-mysql-stored-procedures.aspx
*/
namespace Airline_Crew_Scheduler_G9
{

    public class EmployeeAccessor
    {
        //Todo: Create an Employee insertion method
        public void InsertEmployee(Employee newEmployee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: Create an Employee retreival method
        public List<Employee> RetrieveEmployee()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                var EmpList = connection.Query<Employee>("/*StoredProcdedureCall*/").ToList();
                return EmpList;
            }
        }

        //Todo: Create an Employee Update Method

        public void UpdateEmployee(Employee employeeToUpdate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }

        //Todo: Create an Employee deletion Method


        public void DeleteEmployee(Employee deadEmployee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {
                connection.Query("/*StoredProcdedureCall*/");
                return;
            }
        }
    }


}
