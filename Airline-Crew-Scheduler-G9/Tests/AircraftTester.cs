//TODO: Implement Method Testers, the arguments are just what the methods rely on in the other classes, at this moment
//They still need to be changed to whatever the relevent tester needs, feel free to make any edits for the better

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Airline_Crew_Scheduler_G9.BusinessObjects;
using Airline_Crew_Scheduler_G9.DataAccessors;


namespace Airline_Crew_Scheduler_G9.Tests
{
    [TestClass]
    public class AircraftTester
    {
        //TODO: Create instantiation tests for Aircraft abstract types Gbr10 and Nu150 
        [TestMethod]
        public void Gbr10Tester()
        {

            // Arrange
            int airplaneID = 10;
            string registrationNo = "test";

            // Act
            Aircraft gbr = new Gbr10(airplaneID, registrationNo);

            // Assert
            Assert.IsNotNull(gbr, "Gbr10 was not constructed properly");
        }

        [TestMethod]
        public void Nu150Tester()
        {
            // Arrange
            int airplaneID = 11;
            string registrationNo = "test";

            // Act
            Aircraft nu = new Nu150(airplaneID, registrationNo);

            // Assert
            Assert.IsNotNull(nu, "Nu150 was not constructed properly");
        }

        [TestMethod]
        public void QualifiedCrewCheckTester()
        {
            // Arrange
            int airplaneID_Gbr10 = 10;
            int airplaneID_Nu150 = 11;
            string registrationNo_Gbr10 = "test0";
            string registrationNo_Nu150 = "test1";
            Aircraft gbr = new Gbr10(airplaneID_Gbr10, registrationNo_Gbr10);
            Aircraft nu = new Nu150(airplaneID_Nu150, registrationNo_Nu150);

            int captain = 1;
            int firstOfficer_Gbr10_pass = 2;



            //Crew crew_Gbr10_pass = new Crew(captain, firstOfficer_Gbr10_pass, flightAttendant1, flightAttendant2);
            //Crew crew_Gbr10_fail = new Crew(captain, firstOfficer_Gbr10_pass, flightAttendant1, flightAttendant2);
            //Crew crew_Nu150_pass = new Crew(captain, firstOfficer_Gbr10_pass, flightAttendant1, flightAttendant2);
            //Crew crew_Gbr10_fail = new Crew(captain, firstOfficer_Gbr10_pass, flightAttendant1, flightAttendant2);


            // Act



            // Assert



        }

        // Not required  for project but could be implemented for more extensive features
        [TestMethod]
        public void InsertAircraftTester()
        {
            // Arrange


            // Act


            // Assert

        }


        [TestMethod]
        public void RetrieveGbr10AircraftTester()
        {
            // Arrange
            Aircraft aircraft = null;

            // Act
            aircraft = AircraftAccessor.RetrieveGbr10Aircraft()[0];

            // Assert
            Assert.IsNotNull(aircraft, "Gbr10 was not properly retrieved");
        }

        [TestMethod]
        public void RetrieveNu150AircraftTester()
        {
            // Arrange
            Aircraft aircraft = null;

            // Act
            aircraft = AircraftAccessor.RetrieveNu150Aircraft()[0];

            // Assert
            Assert.IsNotNull(aircraft, "Nu150 was not properly retrieved");


        }

        // Not required  for project but could be implemented for more extensive features
        [TestMethod]
        public void UpdateAircraftTester()
        {
            // Arrange


            // Act


            // Assert
        }

        // Not required  for project but could be implemented for more extensive features
        [TestMethod]
        public void DeleteAircraftTester()
        {
            // Arrange


            // Act


            // Assert
        }
    }
}
