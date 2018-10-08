using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Buffteks.Models
{
    public class MenuCommands
    {
        public static void CreateRecord() {            
            bool exitCreateMenu = false;
            while (exitCreateMenu == false) {
                Console.WriteLine("Create Menu: s (create student), f (create faculty), c (create client), t (create team), or e (exit menu): ");
                string choice = Console.ReadLine();
                switch (choice) {
                    case "s":  
                        CreateCommands.CreateStudent();                 
                        break;
                    case "f":
                        CreateCommands.CreateFaculty();
                        break;
                    case "c":
                        CreateCommands.CreateClient();
                        break;
                    case "t":
                        CreateCommands.CreateTeam();
                        break;
                    case "e":
                        exitCreateMenu = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        } 
        public static void ReadRecord() {            
            bool exitReadMenu = false;     
            while (exitReadMenu == false) {
                Console.WriteLine("Read Menu: s (read student), f (read faculty), c (read client), t (read team), or e (exit menu): ");
                string choice = Console.ReadLine();
                switch (choice) {
                    case "s":  
                        Console.WriteLine("View all student records (a), find a student record (f), or exit (e):");
                        string readsChoice = Console.ReadLine();                    
                        switch (readsChoice) {
                            case "a":
                                ReadCommands.ReadAllStudentRecords();
                                break;
                            case "f":
                                ReadCommands.FindStudentRecord();
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Try again.");
                                break;
                        }
                        break;
                    case "f":
                        Console.WriteLine("View all faculty records (a), find a faculty record (f), or exit (e):");
                        string readfChoice = Console.ReadLine();
                        switch (readfChoice) {
                            case "a":
                                ReadCommands.ReadAllFacultyRecords();
                                break;
                            case "f":
                                ReadCommands.FindFacultyRecord();
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Try again.");
                                break;                            
                        }
                        break;
                    case "c":
                        Console.WriteLine("View all client records (a), find a client record (f), or exit (e):");
                        string readcChoice = Console.ReadLine();
                        switch (readcChoice) {
                            case "a":
                                ReadCommands.ReadAllClientRecords();
                                break;
                            case "f":
                                ReadCommands.FindClientRecord();
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Try again.");
                                break;                            
                        }
                        break;
                    case "t":
                        Console.WriteLine("View all team records (a), find a team record (f), or exit (e):");
                        string readtChoice = Console.ReadLine();
                        switch (readtChoice) {
                            case "a":
                                ReadCommands.ReadAllTeamRecords();
                                break;
                            case "f":
                                ReadCommands.FindTeamRecord();
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Try again.");
                                break;                            
                        }
                        break;
                    case "e":
                        exitReadMenu = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
        public static void UpdateRecord() {            
            bool exitUpdateMenu = false;
            while (exitUpdateMenu == false) {
                Console.WriteLine("Update Menu: s (update student), f (update faculty), c (update client), or e (exit menu): ");
                string choice = Console.ReadLine();
                switch (choice) {
                    case "s":                        
                        Console.WriteLine("Sorry! This function isn't ready yet!");
                        break;
                    case "f":
                        Console.WriteLine("Sorry! This function isn't ready yet!");
                        break;
                    case "c":
                        Console.WriteLine("Sorry! This function isn't ready yet!");
                        break;
                    case "e":
                        exitUpdateMenu = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
        public static void DeleteRecord() {            
            bool exitDeleteMenu = false;
            while (exitDeleteMenu == false) {
                Console.WriteLine("Delete Menu: s (delete student), f (delete faculty), c (delete client), or e (exit menu): ");
                string choice = Console.ReadLine();
                switch (choice) {
                    case "s":
                        Console.WriteLine("Sorry! This function isn't ready yet!");
                        break;
                    case "f":
                        Console.WriteLine("Sorry! This function isn't ready yet!");
                        break;
                    case "c":
                        Console.WriteLine("Sorry! This function isn't ready yet!");
                        break;
                    case "e":
                        exitDeleteMenu = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}