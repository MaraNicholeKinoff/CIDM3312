using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace Buffteks.Models
{
    public class CreateCommands
    {
        public static void CreateTeam() {
            Console.Write("Team name: ");
            string teamName = Console.ReadLine();
            using (var context = new EFIADBContext()) {
                List<Team> teams = new List<Team>()
                {
                    new Team() 
                    {
                        TeamName = teamName
                    }
                };
                context.Team.AddRange(teams);                    
                context.SaveChanges();
            }
            Console.WriteLine("Team record added.");
        }
        public static void CreateClient() {
            Console.Write("Client's first name: ");
            string c_fName = Console.ReadLine();
            Console.Write("Client's last name: ");
            string c_lName = Console.ReadLine();
            Console.Write("Client's phone number: ");
            string c_phoneNumber = Console.ReadLine();
            Console.Write("Client's email: ");
            string c_email = Console.ReadLine();
            Console.Write("Client's company ID: ");
            int c_company = Convert.ToInt32(Console.ReadLine());
            using (var context = new EFIADBContext()) {
                List<Client> clients = new List<Client>()
                {
                    new Client() 
                    {
                        FirstName = c_fName, 
                        LastName = c_lName, 
                        PhoneNumber = c_phoneNumber, 
                        Email = c_email, 
                        OrganizationID = c_company 
                    }
                };
                context.Client.AddRange(clients);                    
                context.SaveChanges();
            }
            Console.WriteLine("Client record added.");
        }
        public static void CreateFaculty() {
            Console.Write("Faculty members's first name: ");
            string f_fName = Console.ReadLine();
            Console.Write("Faculty members's last name: ");
            string f_lName = Console.ReadLine();
            Console.Write("Faculty members's phone number: ");
            string f_phoneNumber = Console.ReadLine();
            Console.Write("Faculty members's email: ");
            string f_email = Console.ReadLine();
            Console.Write("Faculty members's department: ");
            string f_department = Console.ReadLine();
            using (var context = new EFIADBContext()) {
            List<FacultySponsor> sponsors = new List<FacultySponsor>()
            {
                new FacultySponsor() 
                {
                    FirstName = f_fName, 
                    LastName = f_lName, 
                    PhoneNumber = f_phoneNumber, 
                    Email = f_email, 
                    DepartmentName = f_department 
                }
            };
            context.FacultySponsor.AddRange(sponsors);                    
            context.SaveChanges();
            }
            Console.WriteLine("Faculty member record added.");
        }
        public static void CreateStudent() {
            Console.Write("Student's first name: ");
            string s_fName = Console.ReadLine();
            Console.Write("Student's last name: ");
            string s_lName = Console.ReadLine();
            Console.Write("Student's phone number: ");
            string s_phoneNumber = Console.ReadLine();
            Console.Write("Student's email: ");
            string s_email = Console.ReadLine();
            Console.Write("Student's major: ");
            string s_major = Console.ReadLine();
            using (var context = new EFIADBContext()) {
            List<Student> students = new List<Student>()
            {
                new Student() 
                {
                    FirstName = s_fName, 
                    LastName = s_lName, 
                    PhoneNumber = s_phoneNumber, 
                    Email = s_email, 
                    Major = s_major 
                }
            };
            context.Student.AddRange(students);                    
            context.SaveChanges();
            }
            Console.WriteLine("Student record added.");
        }
    }
}