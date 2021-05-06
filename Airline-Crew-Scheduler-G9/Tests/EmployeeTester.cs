//TODO: Implement Method Testers, the arguments are just what the methods rely on in the other classes, at this moment
//They still need to be changed to whatever the relevent tester needs, feel free to make any edits for the better

using Airline_Crew_Scheduler_G9.BusinessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Airline_Crew_Scheduler_G9.Tests
{
    [TestClass]
    public class EmployeeTester
    {
        //TODO: Employee Class Instantiation Tests until next TODO:
        [TestMethod]
        public void EmployeeTest()
        {
            // Arrange
            int employeeID = 10;
            string lastName = "John";
            string firstName = "Eric";
            bool Gbr10Certification = true;
            bool Nu150Certification = false;

     

            // Act
            Employee e = new Employee(employeeID, lastName, firstName, Gbr10Certification, Nu150Certification);

            // Assert
            Assert.IsNotNull(e, "Employee was not constructed correctly");
        }


        //TODO: SQL database Method Tests, SQL database models must be implemented first
        // Not required  for project but could be implemented for more extensive features
        [TestMethod]
        public void InsertEmployeeTester()
        {

        }

        [TestMethod]
        // Not required  for project but could be implemented for more extensive features
        public void RetrieveEmployeeTester()
        {

        }

        [TestMethod]
        // Not required  for project but could be implemented for more extensive features
        public void UpdateEmployeeTester()
        {

        }

        [TestMethod]
        // Not required  for project but could be implemented for more extensive features
        public void DeleteEmployeeTester()
        {

        }
    }
}