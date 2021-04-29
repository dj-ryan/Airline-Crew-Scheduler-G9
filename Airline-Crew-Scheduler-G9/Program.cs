using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Airline_Crew_Scheduler_G9.BusinessObjects;
using Airline_Crew_Scheduler_G9.DataAccessors;

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
            //DataTable allAircraft = AircraftAccessor.RetrieveAircraft();
            //allAircraft = AircraftAccessor.RetrieveAircraft();
            Console.SetWindowSize(100, 30);
            var running = true;
            while (running)
            {
                string input = "";
                ushort choice = 0;
                //Console.Clear();
                foreach (DataRow dataRow in allAircraft.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        Console.WriteLine(item);
                    }
                }
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
                    input = Console.ReadLine();
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
                                WriteLineCentered("Our incredible flight team consists of 8 crews! Each includes a qualified captain and");
                                WriteLineCentered("copilot as well as up to two flight attendants.");
                                //TODO: Get and display crew information
                                Console.WriteLine("ENTER (1) TO RETURN TO HOME PAGE");
                                Console.WriteLine("===================================================================================================");
                                input = Console.ReadLine();
                            } while (input != "1");
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
                                Console.WriteLine("ENTER (1) TO RETURN TO HOME PAGE");
                                Console.WriteLine("===================================================================================================");
                                input = Console.ReadLine();
                            } while (input != "1");
                            break;
                        case 3:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("===================================================================================================");
                                Console.WriteLine("[3]--------------------------------------Flight Information----------------------------------------");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                WriteLineCentered("--Upcoming Flights--");
                                //Todo: display upcoming flights
                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                WriteLineCentered("--Current Flights--");
                                //Todo: display current flights
                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                WriteLineCentered("--Completed Flights--");
                                //Todo: display completed flights
                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                Console.WriteLine("ENTER (1) TO RETURN TO HOME PAGE");
                                Console.WriteLine("ENTER (2) TO REFRESH FLIGHT LIST");
                                Console.WriteLine("===================================================================================================");
                                input = Console.ReadLine();
                            } while (input != "1");
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
                                Console.WriteLine("ENTER (5) TO RETURN TO HOME PAGE");
                                Console.WriteLine("ENTER (6) TO RESTART");
                                Console.WriteLine("===================================================================================================");
                                input = Console.ReadLine();

                                var invalidChoice = true;
                                Airport originAirport = null;
                                while (invalidChoice)
                                {
                                    invalidChoice = false;
                                    //when data accessors are implemented, this should be changed to get the airport from the database
                                    
                                    switch (input)
                                    {
                                        case "1":
                                            originAirport = new Airport(1, "Lincoln", "Nebraska");
                                            break;
                                        case "2":
                                            originAirport = new Airport(2, "Iowa City", "Iowa");
                                            break;
                                        case "3":
                                            originAirport = new Airport(3, "Evanston", "Illinois");
                                            break;
                                        case "4":
                                            originAirport = new Airport(4, "West Lafayette", "Indiana");
                                            break;
                                        case "5":
                                            break;
                                        case "6":
                                            break;
                                        default:
                                            Console.Write("Input is invalid. Please enter a valid option: ");
                                            invalidChoice = true;
                                            input = Console.ReadLine();
                                            break;
                                    }
                                }

                                if (input != "5" && input != "6")
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
                                    Console.WriteLine("ENTER (5) TO RETURN TO HOME PAGE");
                                    Console.WriteLine("ENTER (6) TO RESTART");
                                    Console.WriteLine("===================================================================================================");
                                    input = Console.ReadLine();

                                    while (firstInput == input)
                                    {
                                        Console.WriteLine("The destination airport cannot be the same as the origin airport.");
                                        input = Console.ReadLine();
                                    }

                                    invalidChoice = true;
                                    Airport destinationAirport = null;
                                    while (invalidChoice)
                                    {
                                        invalidChoice = false;
                                        //when data accessors are implemented, this should be changed to get the airport from the database

                                        switch (input)
                                        {
                                            case "1":
                                                destinationAirport = new Airport(1, "Lincoln", "Nebraska");
                                                break;
                                            case "2":
                                                destinationAirport = new Airport(2, "Iowa City", "Iowa");
                                                break;
                                            case "3":
                                                destinationAirport = new Airport(3, "Evanston", "Illinois");
                                                break;
                                            case "4":
                                                destinationAirport = new Airport(4, "West Lafayette", "Indiana");
                                                break;
                                            case "5":
                                                break;
                                            case "6":
                                                break;
                                            default:
                                                Console.Write("Input is invalid. Please enter a valid option: ");
                                                invalidChoice = true;
                                                input = Console.ReadLine();
                                                break;
                                        }
                                    }

                                    if (input != "5" && input != "6")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("===================================================================================================");
                                        Console.WriteLine("[4]--------------------------------------Schedule A Flight!----------------------------------------");
                                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                        if (originAirport != null)
                                            WriteLineCentered("ORIGIN: " + originAirport.City + ", " + originAirport.State);
                                        if (destinationAirport != null)
                                            WriteLineCentered("DESTINATION: " + destinationAirport.City + ", " + destinationAirport.State);
                                        Console.WriteLine("Next, Select the date.");
                                        //TODO: 
                                        Console.WriteLine("TO BE IMPLEMENTED....");
                                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("ENTER (5) TO RETURN TO HOME PAGE");
                                        Console.WriteLine("ENTER (6) TO RESTART");
                                        Console.WriteLine("===================================================================================================");
                                        input = Console.ReadLine();
                                    }
                                }
                                
                                
                            } while (input != "5");
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
