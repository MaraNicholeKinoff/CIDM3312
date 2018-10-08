using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace Buffteks.Models
{
    public class SeedCommands
    {
        
        public static void CreateSeedData() {
            //This opens then closes the connection to the DB, helps security
            using (var context = new EFIADBContext()) {

                //Take this out later - this is deleting the db file
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }

            //This opens then closes the connection to the DB, helps security
            using (var context = new EFIADBContext()) {
                var testStudent0 = new Student {
                    FirstName = "Mara", 
                    LastName = "Kinoff", 
                    PhoneNumber = "XXX-XXX-XXXX", 
                    Email = "mara@domain.com", 
                    Major = "CIS" 
                };
                //This statement adds the student to the DB
                context.Student.Add(testStudent0);
                var testStudent1 = new Student {
                    FirstName = "Sean", 
                    LastName = "Kinoff", 
                    PhoneNumber = "XXX-XXX-XXXX", 
                    Email = "sean@domain.com", 
                    Major = "CIS" 
                };
                context.Student.Add(testStudent1);
                //This statement saves any changes to the DB
                context.SaveChanges();
            }
            using (var context = new EFIADBContext()) {
                var testClient0 = new Client {
                    FirstName = "John", 
                    LastName = "Smith", 
                    PhoneNumber = "XXX-XXX-XXXX", 
                    Email = "john@domain.com", 
                    OrganizationID = 1
                };
                context.Client.Add(testClient0);
                var testClient1 = new Client {
                    FirstName = "Jane", 
                    LastName = "Smith", 
                    PhoneNumber = "XXX-XXX-XXXX", 
                    Email = "jane@domain.com", 
                    OrganizationID = 2
                };
                context.Client.Add(testClient1);                     
                context.SaveChanges();
            }
            using (var context = new EFIADBContext()) {
                var testSponsor0 = new FacultySponsor {
                    FirstName = "Jeff", 
                    LastName = "Babb", 
                    PhoneNumber = "XXX-XXX-XXXX", 
                    Email = "jeff@domain.com" 
                };       
                context.FacultySponsor.Add(testSponsor0);           
                context.SaveChanges();
            }
            using (var context = new EFIADBContext()) {
                var testTeam0 = new Team { 
                    TeamName = "First Team"
                    // LeaderStudentID = 2
                };       
                context.Team.Add(testTeam0);           
                context.SaveChanges();

                //Creating the list of test students
                if(!context.Student.Any())
                {
                    Console.WriteLine("Checking if database exists......");
                    Console.WriteLine("It does not.");
                    Console.WriteLine("Creating database...seeding database...");
                    List<Student> students = new List<Student>()
                    {
                        new Student() 
                        {
                            FirstName = "Mara", 
                            LastName = "Kinoff", 
                            PhoneNumber = "XXX-XXX-XXXX", 
                            Email = "mara@domain.com", 
                            Major = "CIS" 
                        },
                        new Student() 
                        {
                            FirstName = "Sean", 
                            LastName = "Kinoff", 
                            PhoneNumber = "XXX-XXX-XXXX", 
                            Email = "sean@domain.com", 
                            Major = "CIS" 
                        }
                    };
                    context.Student.AddRange(students);                    
                    context.SaveChanges();
                }

                //Creating the list of test clients
                if(!context.Client.Any())
                {
                    List<Client> clients = new List<Client>()
                    {
                        new Client() 
                        {
                            FirstName = "John", 
                            LastName = "Smith", 
                            PhoneNumber = "XXX-XXX-XXXX", 
                            Email = "john@domain.com", 
                            OrganizationID = 1
                        },
                        new Client() 
                        {
                            FirstName = "Jane", 
                            LastName = "Smith", 
                            PhoneNumber = "XXX-XXX-XXXX", 
                            Email = "jane@domain.com", 
                            OrganizationID = 2
                        }
                    };
                    context.Client.AddRange(clients);                    
                    context.SaveChanges();
                }

                //Creating the list of test faculty
                if(!context.FacultySponsor.Any())
                {
                    List<FacultySponsor> facultySponsors = new List<FacultySponsor>()
                    {
                        new FacultySponsor() 
                        {
                            FirstName = "Jeff", 
                            LastName = "Babb", 
                            PhoneNumber = "XXX-XXX-XXXX", 
                            Email = "jeff@domain.com",
                            DepartmentName = "Computer Information and Decision Management" 
                        },
                        new FacultySponsor() 
                        {
                            FirstName = "Katherine", 
                            LastName = "Payne", 
                            PhoneNumber = "XXX-XXX-XXXX", 
                            Email = "katherine@domain.com",
                            DepartmentName = "Computer Information and Decision Management" 
                        }
                    };
                    context.FacultySponsor.AddRange(facultySponsors);                    
                    context.SaveChanges();
                }

                //Creating the list of test teams
                if(!context.Team.Any())
                {
                    List<Team> teams = new List<Team>()
                    {
                        new Team() 
                        {
                            TeamName = "Team Alpha"
                        },
                        new Team() 
                        {
                            TeamName = "Team Beta"
                        }
                    };
                    context.Team.AddRange(teams);                    
                    context.SaveChanges();
                }

            }

            // using (var context = new EFIADBContext()) {
            //     var testStudentTeam0 = new StudentTeams{ 
            //         TeamID = 1,
            //         StudentID = 1,
            //         Role = "Front End Developer"
            //     };       
            //     context.StudentTeams.Add(testStudentTeam0);      
            //     var testStudentTeam1 = new StudentTeams{ 
            //         TeamID = 1,
            //         StudentID = 2,
            //         Role = "Back End Developer"
            //     };       
            //     context.StudentTeams.Add(testStudentTeam1);       
            //     context.SaveChanges();
            // }
        }
    }
}