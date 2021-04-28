//Todo: Create Employee db CRUD methods
using Airline_Crew_Scheduler_G9.BusinessObjects;
using System.Collections;
using System.Collections.Generic;
using Dapper;
using System;
using Airline_Crew_Scheduler_G9.DataAccessors;
using System.Data;

namespace Airline_Crew_Scheduler_G9
{

    public class EmployeeAccessor
    {
        //Todo: Create an Employee insertion method
        public void InsertEmployee(BusinessObjects.Employee newEmployee /*, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create an Employee retreival method
        public List<Employee> RetrieveEmployee(/* query, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create an Employee Update Method

        public void UpdateEmployee(BusinessObjects.Employee employeeToUpdate/* query, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }

        //Todo: Create an Employee deletion Method


        public void DeleteEmployee(BusinessObjects.Employee deadEmployee/* query, dbConnection  */)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AccessorHelper.ConnectVal("airportDB")))
            {

            }
            throw new NotImplementedException();
        }
    }


}
