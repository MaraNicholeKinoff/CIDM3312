using System;
using Buffteks.Models;

namespace Buffteks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Data - Hard coded Create New Data       
            SeedCommands.CreateSeedData();

            //Menu
            bool exitMainMenu = false;
            while (exitMainMenu == false) {
                Console.WriteLine("Main Menu: c (create record), r (read record), u (update record), d (delete record), or e (exit menu): ");
                string choice = Console.ReadLine();
                switch (choice) {
                    case "c":                        
                        MenuCommands.CreateRecord();
                        break;
                    case "r":
                        MenuCommands.ReadRecord();
                        break;
                    case "u":
                        MenuCommands.UpdateRecord();
                        break;
                    case "d":
                        MenuCommands.DeleteRecord();
                        break;
                    case "e":
                        exitMainMenu = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
