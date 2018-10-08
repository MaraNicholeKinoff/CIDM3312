using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace Buffteks.Models
{
    public class ReadCommands
    {
        public static void ReadAllTeamRecords() {
            using (var context = new EFIADBContext()) {
                var teams = context.Team.ToList();
                foreach(Team c in teams)
                {
                    Console.WriteLine(c);
                }
            }
        }
        public static void FindTeamRecord() {
            Console.WriteLine("Sorry! This function isn't ready yet!");
            Console.Write("Enter team name, know that it must be an exact match: ");
            string findTeam = Console.ReadLine();
            using (var context = new EFIADBContext()) 
            {
                var teams = context.Team.ToList();
                foreach (Team t in teams)
                {
                    if (t.TeamName == findTeam) {
                        Console.WriteLine("Team found.");
                        Console.WriteLine("Deleting team...");
                        //Insert code here to delete the record
                        Console.WriteLine("Team deleted.");
                    }
                }
            }
        }
        public static void ReadAllClientRecords() {
            using (var context = new EFIADBContext()) {
                var clients = context.Client.ToList();
                foreach(Client c in clients)
                {
                    Console.WriteLine(c);
                }
            }
        }
        public static void FindClientRecord() {
            Console.WriteLine("Sorry! This function isn't ready yet!");
        }
        public static void ReadAllFacultyRecords() {
            using (var context = new EFIADBContext()) {
                if(context.Client.Any())
                {
                    var facultySponsors = context.FacultySponsor.ToList();
                    foreach(FacultySponsor f in facultySponsors)
                    {
                        Console.WriteLine(f);
                    }
                }
            }
        }
        public static void FindFacultyRecord() {
            Console.WriteLine("Sorry! This function isn't ready yet!");
        }
        public static void ReadAllStudentRecords() {
            using (var context = new EFIADBContext()) {
                var students = context.Student.ToList();
                foreach(Student s in students)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void FindStudentRecord() {
            Console.WriteLine("Sorry! This function isn't ready yet!");
        }
    }
}