using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace LINQ_Practice
{
    public class SeedCommands
    {
        
        public static void CreateSeedData() {
            using (var context = new AppDbContext()) {

                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                if(!context.Student.Any()) {
                    List<Student> students = new List<Student>() {
                        new Student() {
                            FirstName = "Laith",
                            LastName = "Alfaloujeh",
                            PhoneNumber = "123-555-1234",
                            Email = "laith@buffs.wtamu.edu",
                            Role = "Freshman",
                            Taken3350 = false
                        },
                        new Student() {
                            FirstName = "Mekkala",
                            LastName = "Bourapa",
                            PhoneNumber = "456-684-4684",
                            Email = "mekkala@buffs.wtamu.edu",
                            Role = "Sophomore",
                            Taken3350 = true
                        },
                        new Student() {
                            FirstName = "Charles",
                            LastName = "Coufal",
                            PhoneNumber = "123-555-1234",
                            Email = "charles@buffs.wtamu.edu",
                            Role = "Junior",
                            Taken3350 = true
                        }, 
                        new Student() {
                            FirstName = "John",
                            LastName = "Cunningham",
                            PhoneNumber = "123-555-1234",
                            Email = "john@buffs.wtamu.edu",
                            Role = "Senior",
                            Taken3350 = true
                        },   
                        new Student() {
                            FirstName = "Michael",
                            LastName = "Hayes",
                            PhoneNumber = "123-555-1234",
                            Email = "michael@buffs.wtamu.edu",
                            Role = "Freshman",
                            Taken3350 = false
                        },
                        new Student() {
                            FirstName = "Aaron",
                            LastName = "Herbert",
                            PhoneNumber = "456-684-4684",
                            Email = "aaron@buffs.wtamu.edu",
                            Role = "Sophomore",
                            Taken3350 = false
                        },
                        new Student() {
                            FirstName = "Yi Fu",
                            LastName = "Ji",
                            PhoneNumber = "123-555-1234",
                            Email = "yifu@buffs.wtamu.edu",
                            Role = "Junior",
                            Taken3350 = true
                        }, 
                        new Student() {
                            FirstName = "Todd",
                            LastName = "Kile",
                            PhoneNumber = "123-555-1234",
                            Email = "todd@buffs.wtamu.edu",
                            Role = "Senior",
                            Taken3350 = true
                        },   
                        new Student() {
                            FirstName = "Mara",
                            LastName = "Kinoff",
                            PhoneNumber = "123-555-1234",
                            Email = "mara@buffs.wtamu.edu",
                            Role = "Freshman",
                            Taken3350 = false
                        },
                        new Student() {
                            FirstName = "Cesareo",
                            LastName = "Lona",
                            PhoneNumber = "456-684-4684",
                            Email = "cesareo@buffs.wtamu.edu",
                            Role = "Sophomore",
                            Taken3350 = true
                        },
                        new Student() {
                            FirstName = "Michael",
                            LastName = "Matthews",
                            PhoneNumber = "123-555-1234",
                            Email = "michael@buffs.wtamu.edu",
                            Role = "Junior",
                            Taken3350 = true
                        }, 
                        new Student() {
                            FirstName = "Mason",
                            LastName = "McCollum",
                            PhoneNumber = "123-555-1234",
                            Email = "mason@buffs.wtamu.edu",
                            Role = "Senior",
                            Taken3350 = true
                        },
                        new Student() {
                            FirstName = "Alexander",
                            LastName = "McDonald",
                            PhoneNumber = "123-555-1234",
                            Email = "alexander@buffs.wtamu.edu",
                            Role = "Freshman",
                            Taken3350 = false
                        },
                        new Student() {
                            FirstName = "Phelps",
                            LastName = "Merrell",
                            PhoneNumber = "456-684-4684",
                            Email = "phelps@buffs.wtamu.edu",
                            Role = "Sophomore",
                            Taken3350 = false
                        },
                        new Student() {
                            FirstName = "Quan",
                            LastName = "Nguyen",
                            PhoneNumber = "123-555-1234",
                            Email = "quan@buffs.wtamu.edu",
                            Role = "Junior",
                            Taken3350 = true
                        }, 
                        new Student() {
                            FirstName = "Alexander",
                            LastName = "Roder",
                            PhoneNumber = "123-555-1234",
                            Email = "alexander@buffs.wtamu.edu",
                            Role = "Senior",
                            Taken3350 = true
                        },
                        new Student() {
                            FirstName = "Amy",
                            LastName = "Saysouriyosack",
                            PhoneNumber = "123-555-1234",
                            Email = "amy@buffs.wtamu.edu",
                            Role = "Freshman",
                            Taken3350 = false
                        },
                        new Student() {
                            FirstName = "Claudia",
                            LastName = "Silva",
                            PhoneNumber = "456-684-4684",
                            Email = "claudia@buffs.wtamu.edu",
                            Role = "Sophomore",
                            Taken3350 = true
                        },
                        new Student() {
                            FirstName = "Gabriela",
                            LastName = "Valenzuela",
                            PhoneNumber = "123-555-1234",
                            Email = "gabriela@buffs.wtamu.edu",
                            Role = "Junior",
                            Taken3350 = true
                        }, 
                        new Student() {
                            FirstName = "Kayla",
                            LastName = "Washington",
                            PhoneNumber = "123-555-1234",
                            Email = "kayla@buffs.wtamu.edu",
                            Role = "Senior",
                            Taken3350 = true
                        },   
                        new Student() {
                            FirstName = "Mathhew",
                            LastName = "Webb",
                            PhoneNumber = "123-555-1234",
                            Email = "matthew@buffs.wtamu.edu",
                            Role = "Freshman",
                            Taken3350 = false
                        },
                        new Student() {
                            FirstName = "Cory",
                            LastName = "Williams",
                            PhoneNumber = "456-684-4684",
                            Email = "cory@buffs.wtamu.edu",
                            Role = "Sophomore",
                            Taken3350 = true
                        }                              
                    };

                    context.Student.AddRange(students);  
                    context.SaveChanges();                                              

                }
            } 
        }
    }
}