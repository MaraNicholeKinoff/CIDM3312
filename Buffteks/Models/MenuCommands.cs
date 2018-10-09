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
                Console.WriteLine("Create Menu: s (student), f (faculty), c (client), t (team), o (organization), or e (exit menu): ");
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
                    case "o":
                        CreateCommands.CreateOrganization();
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
                Console.WriteLine("Read Menu: s (student), f (faculty), c (client), t (team), o (organization), or e (exit menu): ");
                string choice = Console.ReadLine();
                switch (choice) {
                    case "s":  
                        Console.WriteLine("View all students (a), find a student (f), or exit (e):");
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
                        Console.WriteLine("View all advisors (a), find an advisor (f), or exit (e):");
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
                        Console.WriteLine("View all clients (a), find a client (f), or exit (e):");
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
                    case "o":
                        Console.WriteLine("View all organizations (a), find an organizaion (f), or exit (e):");
                        string readoChoice = Console.ReadLine();
                        switch (readoChoice) {
                            case "a":
                                ReadCommands.ReadAllOrganizationRecords();
                                break;
                            case "f":
                                ReadCommands.FindOrganizationRecord();
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Try again.");
                                break;                            
                        }
                        break;
                    case "t":
                        Console.WriteLine("View all teams (a), find a team (f), or exit (e):");
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
                Console.WriteLine("Update Menu: s (student), f (faculty), c (client), o (organization), or e (exit menu): ");
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
                    case "o":
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
                Console.WriteLine("Delete Menu: s (student), f (faculty), c (client), o (organization), or e (exit menu): ");
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
                    case "o":
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