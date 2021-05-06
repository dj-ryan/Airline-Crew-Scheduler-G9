//TODO: Implement Method Testers, the arguments are just what the methods rely on in the other classes, at this moment
//They still need to be changed to whatever the relevent tester needs, feel free to make any edits for the better

using System;
using Airline_Crew_Scheduler_G9.BusinessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airline_Crew_Scheduler_G9.Tests


{
    [TestClass]
    public class FlightTester

    {
        [TestMethod]
        public void FlightTest()
        {
            
            // Arrange
            int captain = 10;
            int firstOfficer = 11;
            int flightAttendant1 = 12;
            int flightAttendant2 = 13;
            int timeID = 100;
            DateTime scheduledTakeoffTime = new DateTime(2021, 3, 9, 16, 5, 7);
            DateTime estimatedTakeoffTime = new DateTime(2021, 3, 9, 16, 5, 7);
            DateTime scheduledTouchdownTime = new DateTime(2021, 3, 9, 18, 43, 2);
            DateTime estimatedTouchDownTime = new DateTime(2021, 3, 9, 18, 43, 2);
            int airplaneID = 30;
            string registrationNo = "test";
            int airportId = 2;
            string city = "lincoln";
            string state = "Nebraska";
            int Nu150Main = 200;
            int Gbr10Main = 201;
            int Nu150Standby = 202;
            int Gbr10Standby = 203;

            int flightNumber = 1;
            Aircraft flightAircraft = new Gbr10(airplaneID, registrationNo);
            Crew c = new Crew(captain, firstOfficer, flightAttendant1, flightAttendant2);
            Airport originAirport =
                new Airport(airportId, city, state, Nu150Main, Gbr10Main, Nu150Standby, Gbr10Standby);
            Airport destinationAirport =
                new Airport(airportId, city, state, Nu150Main, Gbr10Main, Nu150Standby, Gbr10Standby);
            FlightTime flightlog = new FlightTime(timeID,
                scheduledTakeoffTime, estimatedTakeoffTime,
                scheduledTouchdownTime, estimatedTouchDownTime);
            int passengerCount = 20;

            // Act
            Flight f = new Flight(flightNumber, flightAircraft, c, originAirport, destinationAirport,
                flightlog, passengerCount);

            // Assert
            Assert.IsNotNull(f, "flight was not constructed properly");
        }

        //TODO: SQL database Method Tests Below, SQL database models must be implemented first
        [TestMethod]
        public void InsertFlightTester()
        {

        }

        [TestMethod]
        public void RetrieveFlightTester()
        {

        }

        [TestMethod]
        public void UpdateFlightTester()
        {

        }

        [TestMethod]
        public void DeleteFlightTester()
        {

        }

        [TestMethod]
        public void RetrieveUpcomingFlightsTester()
        {

        }

        [TestMethod]
        public void UpdateActualTakeffTimeTester()
        {

        }

        [TestMethod]
        public void RetrieveCurrentFlightsTester()
        {

        }

        [TestMethod]
        public void UpdateActualTouchdownTimeTester()
        {

        }

        [TestMethod]
        public void RetrieveCompletedFlightsTester()
        {

        }
    }

}