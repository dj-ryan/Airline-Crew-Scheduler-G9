using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using Airline_Crew_Scheduler_G9.BusinessObjects;
using Airline_Crew_Scheduler_G9.DataAccessors;
using MySqlX.XDevAPI.Common;

namespace Airline_Crew_Scheduler_G9
{
    public class Program
    {
        /* Sources:
        Console Application Guide >> https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2019
        Patrick's Text Mockup >> https://docs.google.com/document/d/13HqbDPXDHulH8E7xu-BqlCOXNvNUFFQDuUu9oPxLmrs/edit
        How to Center Text ??>> https://stackoverflow.com/questions/21917203/how-do-i-center-text-in-a-console-application
        */
        public static void Main()
        {
            
            Console.SetWindowSize(100, 30);
            var running = true;
            while (running)
            {
                ushort choice = 0;
                Console.Clear();
                Console.WriteLine("-------------------------WELCOME TO CORNHUSKER AIRWAYS CONSOLE APPLICATION-------------------------");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine(" Cornhusker Airways (CHA) is a small regional airline that provides high quality flights out of\n " +
                                  "Lincoln, Nebraska; Iowa City, Iowa; Evanston, Illinois; and West Lafayette, Indiana.\n " +
                                  "Enjoy your flight! ");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                WriteLineCentered("Please enter the appropriate number associated with your request then hit enter");
                WriteLineCentered("(1) Crew Information");
                WriteLineCentered("(2) Aircraft Information");
                WriteLineCentered("(3) Flight Information");
                WriteLineCentered("(4) Schedule a Flight!");
                WriteLineCentered("(5) Quit");
                Console.Write("ENTER REQUEST HERE: ");
                

                while (choice == 0)
                {
                    var input = Console.ReadLine();
                    while (!ushort.TryParse(input, out choice))
                    {
                        Console.Write("Input is invalid. Please enter an integer: ");
                        input = Console.ReadLine();

                    }

                    switch (choice)
                    {
                        case 1:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("===================================================================================================");
                                Console.WriteLine("[1]--------------------------------------Crew Information------------------------------------------");
                                WriteLineCentered("Our incredible flight team consists of 16 crews! Each includes a qualified captain and");
                                WriteLineCentered("copilot as well as up to two flight attendants.");
                                
                                foreach (var airport in AirportAccessor.RetrieveAirport())
                                {
                                    //airport.Nu150StandbyCrewID = 0;
                                    //airport.nu150CertifiedCrewList = null;
                                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                    Console.WriteLine(" " + airport + " Crew List");

                                    Console.WriteLine("  GBR-10 Main Crew:");
                                    if (airport.Gbr10MainCrewID != 0)
                                    {
                                        var crew = CrewAccessor.RetrieveCrew(airport.Gbr10MainCrewID);
                                        var cap = EmployeeAccessor.RetrieveEmployee(crew.Captain);
                                        var fo = EmployeeAccessor.RetrieveEmployee(crew.FirstOfficer);
                                        var fa1 = EmployeeAccessor.RetrieveEmployee(crew.FlightAttendant1);
                                        Console.WriteLine("   Captain: " + cap.LastName + "; First Officer: " + fo.LastName + 
                                                          "; Flight Attendant 1: " + fa1.LastName);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\t\t\tNo current Standby Crew...");
                                    }

                                    Console.WriteLine("  NU-150 Main Crew:");

                                    if (airport.Nu150MainCrewID != 0)
                                    {
                                        var crew = CrewAccessor.RetrieveCrew(airport.Nu150MainCrewID);
                                        var cap = EmployeeAccessor.RetrieveEmployee(crew.Captain);
                                        var fo = EmployeeAccessor.RetrieveEmployee(crew.FirstOfficer);
                                        var fa1 = EmployeeAccessor.RetrieveEmployee(crew.FlightAttendant1);
                                        var fa2 = EmployeeAccessor.RetrieveEmployee(crew.FlightAttendant2);
                                        Console.WriteLine("   Captain: " + cap.LastName + "; First Officer: " + fo.LastName +
                                                          "; Flight Attendant 1: " + fa1.LastName + "; Flight Attendant 2: " + fa2.LastName);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\t\t\tNo current Standby Crew...");
                                    }
                                    Console.WriteLine("  GBR-10 Standby Crew:");
                                    if (airport.Gbr10StandbyCrewID != 0)
                                    {
                                        var crew = CrewAccessor.RetrieveCrew(airport.Gbr10StandbyCrewID);
                                        var cap = EmployeeAccessor.RetrieveEmployee(crew.Captain);
                                        var fo = EmployeeAccessor.RetrieveEmployee(crew.FirstOfficer);
                                        var fa1 = EmployeeAccessor.RetrieveEmployee(crew.FlightAttendant1);
                                        Console.WriteLine("   Captain: " + cap.LastName + "; First Officer: " + fo.LastName +
                                                          "; Flight Attendant 1: " + fa1.LastName);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\t\t\tNo current Standby Crew...");
                                    }

                                    Console.WriteLine("  NU-150 Standby Crew:");

                                    if (airport.Nu150StandbyCrewID != 0)
                                    { 
                                        var crew = CrewAccessor.RetrieveCrew(airport.Nu150StandbyCrewID);
                                        var cap = EmployeeAccessor.RetrieveEmployee(crew.Captain);
                                        var fo = EmployeeAccessor.RetrieveEmployee(crew.FirstOfficer);
                                        var fa1 = EmployeeAccessor.RetrieveEmployee(crew.FlightAttendant1);
                                        var fa2 = EmployeeAccessor.RetrieveEmployee(crew.FlightAttendant2);
                                        Console.WriteLine("   Captain: " + cap.LastName + "; First Officer: " + fo.LastName +
                                                          "; Flight Attendant 1: " + fa1.LastName + "; Flight Attendant 2: " + fa2.LastName);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\t\t\tNo current Standby Crew...");
                                    }
                                }
                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                Console.WriteLine("ENTER (q) TO RETURN TO HOME PAGE");
                                Console.WriteLine("===================================================================================================");
                                input = Console.ReadLine();
                            } while (input != "q");
                            break;
                        case 2:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("===================================================================================================");
                                Console.WriteLine("[2]------------------------------------Aircraft Information----------------------------------------");
                                WriteLineCentered("Our fleet consists of two different models: the GBR-10 and the NU-150.");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                WriteLineCentered("GBR-10: This model travels at 500 mph with a total passenger capacity of 45. The crew only");
                                WriteLineCentered("requires a pilot, copilot, and one flight attendant.");
                                WriteLineCentered("NU-150: Much like the GBR-10, this model of plane can travel at speeds up to 500 mph. Unlike");
                                WriteLineCentered("the GBR-10, however, this plane has a passenger capacity of 75 and requires a pilot, copilot,");
                                WriteLineCentered("and up to two flight attendants depending on the current number of passengers.");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                Console.WriteLine("ENTER (q) TO RETURN TO HOME PAGE");
                                Console.WriteLine("===================================================================================================");
                                input = Console.ReadLine();
                            } while (input != "q");
                            break;
                        case 3:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("===================================================================================================");
                                Console.WriteLine("[3]--------------------------------------Flight Information----------------------------------------");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                WriteLineCentered("--Upcoming Flights--");

                                if (FlightAccessor.RetrieveUpcomingFlights() != null)
                                {
                                    foreach (var flight in FlightAccessor.RetrieveUpcomingFlights())
                                    {
                                        WriteLineCentered("Flight No. " + flight.FlightNumber + " " + flight.OriginAirport +
                                                          " --> " + flight.DestinationAirport);
                                        Console.WriteLine("");
                                        Console.WriteLine("                             Departure Scheduled: " + flight.Flightlog.ScheduledTakeoffTime);
                                        Console.WriteLine("                             Estimated Depature : " + flight.Flightlog.EstimatedTakeoffTime);
                                        Console.WriteLine("                             Arrival Scheduled: : " + flight.Flightlog.ScheduledTouchdownTime);
                                        Console.WriteLine("                             Estimated Arrival  : " + flight.Flightlog.EstimatedTouchdownTime);
                                        Console.WriteLine("");
                                    }
                                }
                                
                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                WriteLineCentered("--Current Flights--");

                                
                                //Todo: display current flights
                                
                                if (FlightAccessor.RetrieveCurrentFlights() != null)
                                {
                                    foreach (var flight in FlightAccessor.RetrieveCurrentFlights())
                                    {
                                        WriteLineCentered("Flight No. " + flight.FlightNumber + " " + flight.OriginAirport +
                                                          " --> " + flight.DestinationAirport);
                                        Console.WriteLine("");
                                        Console.WriteLine("                             Departure Scheduled: " + flight.Flightlog.ScheduledTakeoffTime);
                                        Console.WriteLine("                             Estimated Depature : " + flight.Flightlog.EstimatedTakeoffTime);
                                        Console.WriteLine("                             Actual Depature    : " + flight.Flightlog.ActualTakeoffTime);
                                        Console.WriteLine("                             Arrival Scheduled: : " + flight.Flightlog.ScheduledTouchdownTime);
                                        Console.WriteLine("                             Estimated Arrival  : " + flight.Flightlog.EstimatedTouchdownTime);
                                        Console.WriteLine("");
                                    }
                                }
                                

                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                WriteLineCentered("--Completed Flights--");

                                if (FlightAccessor.RetrieveCompletedFlights() != null)
                                {
                                    foreach (var flight in FlightAccessor.RetrieveCompletedFlights())
                                    {
                                        WriteLineCentered("Flight No. " + flight.FlightNumber + " " + flight.OriginAirport +
                                                          " --> " + flight.DestinationAirport);
                                        Console.WriteLine("");
                                        Console.WriteLine("                             Departure Scheduled: " + flight.Flightlog.ScheduledTakeoffTime);
                                        Console.WriteLine("                             Estimated Depature : " + flight.Flightlog.EstimatedTakeoffTime);
                                        Console.WriteLine("                             Actual Depature    : " + flight.Flightlog.ActualTakeoffTime);
                                        Console.WriteLine("                             Arrival Scheduled: : " + flight.Flightlog.ScheduledTouchdownTime);
                                        Console.WriteLine("                             Estimated Arrival  : " + flight.Flightlog.EstimatedTouchdownTime);
                                        Console.WriteLine("                             Actual Arrival     : " + flight.Flightlog.ActualTouchdownTime);
                                        Console.WriteLine("");
                                    }
                                }
                                //Todo: display completed flights
                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                Console.WriteLine("ENTER (q) TO RETURN TO HOME PAGE");
                                Console.WriteLine("ENTER (r) TO REFRESH FLIGHT LIST");
                                Console.WriteLine("===================================================================================================");
                                input = Console.ReadLine();
                            } while (input != "q");
                            break;
                        case 4:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("===================================================================================================");
                                Console.WriteLine("[4]--------------------------------------Schedule A Flight!----------------------------------------");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                Console.WriteLine("First, Select the origin airport.");
                                Console.WriteLine("  (1) Lincoln, Nebraska");
                                Console.WriteLine("  (2) Iowa City, Iowa");
                                Console.WriteLine("  (3) Evanston, Illinois");
                                Console.WriteLine("  (4) West Lafayette, Indiana");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                Console.WriteLine("ENTER (q) TO RETURN TO HOME PAGE");
                                Console.WriteLine("ENTER (r) TO RESTART");
                                Console.WriteLine("===================================================================================================");
                                input = Console.ReadLine();

                                var invalidChoice = true;
                                Airport originAirport = null;
                                while (invalidChoice)
                                {
                                    invalidChoice = false;
                                    switch (input)
                                    {
                                        case "1":
                                            originAirport = AirportAccessor.RetrieveAirport("Lincoln", "Nebraska");
                                            break;
                                        case "2":
                                            originAirport = AirportAccessor.RetrieveAirport("Iowa City", "Iowa");
                                            break;
                                        case "3":
                                            originAirport = AirportAccessor.RetrieveAirport("Evanston", "Illinois");
                                            break;
                                        case "4":
                                            originAirport = AirportAccessor.RetrieveAirport("West Lafayette", "Indiana");
                                            break;
                                        case "q":
                                            break;
                                        case "r":
                                            break;
                                        default:
                                            Console.Write("Input is invalid. Please enter a valid option: ");
                                            invalidChoice = true;
                                            input = Console.ReadLine();
                                            break;
                                    }
                                }

                                if (input != "q" && input != "r")
                                {
                                    string firstInput = input;
                                    Console.Clear();
                                    Console.WriteLine("===================================================================================================");
                                    Console.WriteLine("[4]--------------------------------------Schedule A Flight!----------------------------------------");
                                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                    if (originAirport != null)
                                        WriteLineCentered("ORIGIN: " + originAirport.City + ", " + originAirport.State);
                                    Console.WriteLine("Next, Select the destination airport.");
                                    Console.WriteLine("  (1) Lincoln, Nebraska");
                                    Console.WriteLine("  (2) Iowa City, Iowa");
                                    Console.WriteLine("  (3) Evanston, Illinois");
                                    Console.WriteLine("  (4) West Lafayette, Indiana");
                                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("ENTER (q) TO RETURN TO HOME PAGE");
                                    Console.WriteLine("ENTER (r) TO RESTART");
                                    Console.WriteLine("===================================================================================================");
                                    input = Console.ReadLine();

                                    while (firstInput == input)
                                    {
                                        Console.WriteLine("The destination airport cannot be the same as the origin airport.");
                                        Console.Write("Please enter a valid option: ");
                                        input = Console.ReadLine();
                                    }

                                    invalidChoice = true;
                                    Airport destinationAirport = null;
                                    while (invalidChoice)
                                    {
                                        invalidChoice = false;
                                        switch (input)
                                        {
                                            case "1":
                                                destinationAirport = AirportAccessor.RetrieveAirport("Lincoln", "Nebraska");
                                                break;
                                            case "2":
                                                destinationAirport = AirportAccessor.RetrieveAirport("Iowa City", "Iowa");
                                                break;
                                            case "3":
                                                destinationAirport = AirportAccessor.RetrieveAirport("Evanston", "Illinois");
                                                break;
                                            case "4":
                                                destinationAirport = AirportAccessor.RetrieveAirport("West Lafayette", "Indiana");
                                                break;
                                            case "q":
                                                break;
                                            case "r":
                                                break;
                                            default:
                                                Console.Write("Input is invalid. Please enter a valid option: ");
                                                invalidChoice = true;
                                                input = Console.ReadLine();
                                                break;
                                        }
                                    }

                                    if (input != "q" && input != "r")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("===================================================================================================");
                                        Console.WriteLine("[4]--------------------------------------Schedule A Flight!----------------------------------------");
                                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                        if (originAirport != null)
                                            WriteLineCentered("ORIGIN: " + originAirport.City + ", " + originAirport.State);
                                        if (destinationAirport != null)
                                            WriteLineCentered("DESTINATION: " + destinationAirport.City + ", " + destinationAirport.State);
                                        Console.WriteLine("Next, Enter the date.");
                                        Console.WriteLine(" Dates can be in the form (month/day/year) or (month/day).");
                                        Console.WriteLine(" Ex. 4/30/2021 and 4/30 are the same date.");

                                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("ENTER (q) TO RETURN TO HOME PAGE");
                                        Console.WriteLine("ENTER (r) TO RESTART");
                                        Console.WriteLine("===================================================================================================");

                                        Console.Write("Enter Date: ");
                                        DateTime scheduledDateTime = new DateTime();
                                        string dateString = null;
                                        invalidChoice = true;
                                        while (input != "q" && input != "r" && invalidChoice)
                                        {
                                            input = Console.ReadLine();

                                            DateTime temp;
                                            if(DateTime.TryParse(input, out temp))
                                            {
                                                invalidChoice = false;
                                                if (temp < DateTime.Now.AddDays(-1)) 
                                                {
                                                    Console.Write("Can't schedule a flight in the past. Please enter a valid date: ");
                                                    invalidChoice = true;
                                                }
                                                else
                                                {
                                                    scheduledDateTime = temp;
                                                    dateString = input;
                                                    if (dateString.Split('/').Length - 1 == 1) //changes 4/30 to 4/30/2021
                                                    {
                                                        dateString = dateString + "/" + DateTime.Now.Year;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.Write("Input is invalid. Please enter a valid date: ");
                                                
                                            }

                                            if (input != "q" && input != "r" && !invalidChoice)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("===================================================================================================");
                                                Console.WriteLine("[4]--------------------------------------Schedule A Flight!----------------------------------------");
                                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                if (originAirport != null)
                                                    WriteLineCentered("ORIGIN: " + originAirport.City + ", " + originAirport.State);
                                                if (destinationAirport != null)
                                                    WriteLineCentered("DESTINATION: " + destinationAirport.City + ", " + destinationAirport.State);
                                                WriteLineCentered("DATE: " + scheduledDateTime.ToLongDateString());

                                                Console.WriteLine("Next, Enter the time.");
                                                Console.WriteLine(" The time can be in multiple forms (hour:minute:second), (hour:minute), (hour:minute PM).");
                                                Console.WriteLine(" Ex. These are all the same time: (5 PM), (5:00 PM), (17:00), (17:00:00)");

                                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                Console.WriteLine("ENTER (q) TO RETURN TO HOME PAGE");
                                                Console.WriteLine("ENTER (r) TO RESTART");
                                                Console.WriteLine("===================================================================================================");

                                                Console.Write("Enter Time: ");
                                                invalidChoice = true;
                                                while (input != "q" && input != "r" && invalidChoice)
                                                {
                                                    input = Console.ReadLine();

                                                    if (DateTime.TryParse(dateString + " " + input, out temp))
                                                    {
                                                        invalidChoice = false;
                                                        if (temp < DateTime.Now)
                                                        {
                                                            Console.Write("Can't schedule a flight in the past. Please enter a valid time: ");
                                                            invalidChoice = true;
                                                        }
                                                        else
                                                        {
                                                            scheduledDateTime = temp;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Input is invalid. Please enter a valid time: ");

                                                    }

                                                    if (input != "q" && input != "r" && !invalidChoice)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("===================================================================================================");
                                                        Console.WriteLine("[4]--------------------------------------Schedule A Flight!----------------------------------------");
                                                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                        if (originAirport != null)
                                                            WriteLineCentered("ORIGIN: " + originAirport.City + ", " + originAirport.State);
                                                        if (destinationAirport != null)
                                                            WriteLineCentered("DESTINATION: " + destinationAirport.City + ", " + destinationAirport.State);
                                                        WriteLineCentered("DATE: " + scheduledDateTime.ToLongDateString());
                                                        WriteLineCentered("TIME: " + scheduledDateTime.ToLongTimeString());

                                                        Console.WriteLine("Next, Select the Aircraft.");
                                                        Console.WriteLine("  (1) GBR-10 - Max Passengers: 45");
                                                        Console.WriteLine("  (2) NU-150 - Max Passengers: 75");

                                                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                        Console.WriteLine("ENTER (q) TO RETURN TO HOME PAGE");
                                                        Console.WriteLine("ENTER (r) TO RESTART");
                                                        Console.WriteLine("===================================================================================================");
                                                        
                                                        invalidChoice = true;
                                                        while (input != "q" && input != "r" && invalidChoice)
                                                        {
                                                            Aircraft aircraft = null;
                                                            input = Console.ReadLine();
                                                            invalidChoice = false;
                                                            switch (input)
                                                            {
                                                                case "1": //currently only gets the first aircraft returned
                                                                    aircraft = AircraftAccessor.RetrieveGbr10Aircraft()[0];
                                                                    break;
                                                                case "2":
                                                                    aircraft = AircraftAccessor.RetrieveNu150Aircraft()[0];
                                                                    break;
                                                                case "q":
                                                                    break;
                                                                case "r":
                                                                    break;
                                                                default:
                                                                    invalidChoice = true;
                                                                    break;
                                                            }

                                                            if (input != "q" && input != "r" && !invalidChoice)
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("===================================================================================================");
                                                                Console.WriteLine("[4]--------------------------------------Schedule A Flight!----------------------------------------");
                                                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                                if (originAirport != null)
                                                                    WriteLineCentered("ORIGIN: " + originAirport.City + ", " + originAirport.State);
                                                                if (destinationAirport != null)
                                                                    WriteLineCentered("DESTINATION: " + destinationAirport.City + ", " + destinationAirport.State);
                                                                WriteLineCentered("DATE: " + scheduledDateTime.ToLongDateString());
                                                                WriteLineCentered("TIME: " + scheduledDateTime.ToLongTimeString());
                                                             
                                                                WriteLineCentered("AIRCRAFT TYPE: " + aircraft.planeType);
                                                                
                                                                

                                                                Console.WriteLine("Finally, Select the number of passengers.");

                                                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                                Console.WriteLine("ENTER (q) TO RETURN TO HOME PAGE");
                                                                Console.WriteLine("ENTER (r) TO RESTART");
                                                                Console.WriteLine("===================================================================================================");

                                                                Console.Write("Enter Number of Passengers: ");

                                                                UInt16 passengerCount = 0;
                                                                invalidChoice = true;
                                                                while (input != "q" && input != "r" && invalidChoice)
                                                                {
                                                                    input = Console.ReadLine();

                                                                    if (ushort.TryParse(input, out choice))
                                                                    {

                                                                        invalidChoice = false;
                                                                        if (choice > aircraft.seats)
                                                                        {
                                                                            invalidChoice = true;
                                                                            Console.Write(
                                                                                "Too many passengers. Please enter a smaller number: ");
                                                                        }
                                                                        else
                                                                        {
                                                                            passengerCount = choice;
                                                                        }

                                                                    }
                                                                    else
                                                                    {
                                                                        Console.Write(
                                                                            "Input is invalid. Please enter a positive integer: ");
                                                                    }

                                                                    if (!invalidChoice)
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine(
                                                                            "===================================================================================================");
                                                                        Console.WriteLine(
                                                                            "[4]--------------------------------------Schedule A Flight!----------------------------------------");
                                                                        Console.WriteLine(
                                                                            "---------------------------------------------------------------------------------------------------");
                                                                        if (originAirport != null)
                                                                            WriteLineCentered("ORIGIN: " +
                                                                                originAirport.City + ", " +
                                                                                originAirport.State);
                                                                        if (destinationAirport != null)
                                                                            WriteLineCentered("DESTINATION: " +
                                                                                destinationAirport.City + ", " +
                                                                                destinationAirport.State);
                                                                        WriteLineCentered("DATE: " +
                                                                            scheduledDateTime.ToLongDateString());
                                                                        WriteLineCentered("TIME: " +
                                                                            scheduledDateTime.ToLongTimeString());
                                                                        WriteLineCentered("AIRCRAFT TYPE: " +
                                                                            aircraft.planeType);
                                                                        WriteLineCentered("PASSENGERS: " +
                                                                            passengerCount);

                                                                        Console.WriteLine("Now enter (1) to confirm. ");

                                                                        Console.WriteLine(
                                                                            "---------------------------------------------------------------------------------------------------");
                                                                        Console.WriteLine(
                                                                            "ENTER (q) TO RETURN TO HOME PAGE");
                                                                        Console.WriteLine("ENTER (r) TO RESTART");
                                                                        Console.WriteLine(
                                                                            "===================================================================================================");

                                                                        Console.Write("Enter: ");
                                                                        invalidChoice = true;
                                                                        while (input != "q" && input != "r" &&
                                                                               invalidChoice)
                                                                        {
                                                                            input = Console.ReadLine();
                                                                            invalidChoice = false;
                                                                            switch (input)
                                                                            {
                                                                                case "1":
                                                                                    //add to database
                                                                                    break;
                                                                                case "q":
                                                                                    break;
                                                                                case "r":
                                                                                    break;
                                                                                default:
                                                                                    invalidChoice = true;
                                                                                    Console.Write("Please enter a valid choice: ");
                                                                                    break;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                
                                
                            } while (input != "q");
                            break;
                        case 5:
                            running = false;
                            break;
                        default:
                            Console.Write("Input is invalid. Please enter a valid option: ");
                            choice = 0;
                            break;
                    }
                }
                



            }
        }

        private static void WriteLineCentered(string s)
        {
            Console.WriteLine(String.Format("{0," + (100 / 2 + s.Length / 2) + "}", s));
        }
    }
}
