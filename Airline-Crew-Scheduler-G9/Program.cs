using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Crew_Scheduler_G9
{
    public class Program
    {
        /* Sources:
        Console Application Guide >> https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2019
        Patrick's Text Mockup >> https://docs.google.com/document/d/13HqbDPXDHulH8E7xu-BqlCOXNvNUFFQDuUu9oPxLmrs/edit
        How to Center Text ??>> https://stackoverflow.com/questions/21917203/how-do-i-center-text-in-a-console-application
        */
        static void Main()
        {
            Console.SetWindowSize(100, 30);
            var running = true;
            while (running)
            {
                string input = "";
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
                WriteLineCentered("(3) Flight  Information");
                WriteLineCentered("(4) Quit");
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
            Console.WriteLine(String.Format("{0," + (Console.WindowWidth / 2 + s.Length / 2) + "}", s));
        }
    }
}
