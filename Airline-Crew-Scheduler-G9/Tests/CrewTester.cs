using Airline_Crew_Scheduler_G9.BusinessObjects;
using Airline_Crew_Scheduler_G9.DataAccessors;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Airline_Crew_Scheduler_G9.Tests
{
    //TODO: Implement Method Testers, the arguments are just what the methods rely on in the other classes, at this moment
    //They still need to be changed to whatever the relevent tester needs, feel free to make any edits for the better
    [TestClass]
    public class CrewTester
    {
        //TODO: Crew Class Instantiation Tests
        [TestMethod]
        public void CrewTest()
        {
            // Arrange
            int captain = 10;
            int firstOfficer = 11;
            int flightAttendant1 = 12;
            int flightAttendant2 = 13;

            // Act
            Crew c = new Crew(captain, firstOfficer, flightAttendant1, flightAttendant2);

            // Assert
            Assert.IsNotNull(c, "Crew was not properly constructed");
        }


        [TestMethod]
        public void QualificationCheckTester()
        {

        }

        // Not required  for project but could be implemented for more extensive features
        [TestMethod]
        public void InsertCrewTester()
        {

        }

        [TestMethod]
        public void RetrieveCrewTester()
        {

            // Arrange
            Crew c = null;

            // Act
            c = CrewAccessor.RetrieveCrew(1);

            // Assert
            Assert.IsNotNull(c, "Crew was not properly retrieved");

        }

        // Not required  for project but could be implemented for more extensive features
        [TestMethod]
        public void UpdateCrewTester()
        {
        }

        // Not required  for project but could be implemented for more extensive features
        [TestMethod]
        public void DeleteCrewTester()
        {

        }
    }
}