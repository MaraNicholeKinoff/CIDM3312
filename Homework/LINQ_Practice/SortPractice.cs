using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace LINQ_Practice
{
    public class SortPractice
    { 
        public static void Problem1() {
            //Method Syntax
            Console.WriteLine("\nSort Practice - Problem 1");
            using (var context = new AppDbContext()) {
                var students = context.Student.ToList();
                var sortFName = students.OrderBy(s => s.FirstName); 
                foreach(Student s in sortFName)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void Problem2() {
            //Method Syntax
            Console.WriteLine("\nSort Practice - Problem 2");
            using (var context = new AppDbContext()) {
                var students = context.Student.ToList();
                var sortLName = students.OrderByDescending(s => s.LastName); 
                foreach(Student s in sortLName)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void Problem3() {
            //Method Syntax
            Console.WriteLine("\nSort Practice - Problem 3");
            using (var context = new AppDbContext()) {
                var groupedResult = context.Student.OrderBy(s => s.Role);

                foreach (var s in groupedResult)
                {
                    Console.Write(s.FirstName);
                    Console.Write(" ");
                    Console.Write(s.LastName);
                    Console.Write(" - ");
                    Console.WriteLine(s.Role);
                }
            }
        }
        public static void Problem4() {
            //Using Query Syntax
            Console.WriteLine("\nSort Practice - Problem 4");
            using (var context = new AppDbContext()) {
                var studentsFilteredLName = from s in context.Student
                                            where s.Role == "Senior"
                                            orderby s.LastName
                                            select s;
                foreach (var s in studentsFilteredLName) {
                    Console.Write(s);
                    Console.Write(" - ");
                    Console.WriteLine(s.Role);
                }
            }
        }
        public static void Problem5() {
            //Using Query Syntax
            Console.WriteLine("\nSort Practice - Problem 4");
            using (var context = new AppDbContext()) {
                var studentsFilteredLName = from s in context.Student
                                            where s.Role != "Senior"
                                            orderby s.FirstName descending
                                            select s;
                foreach (var s in studentsFilteredLName) {
                    Console.Write(s);
                    Console.Write(" - ");
                    Console.WriteLine(s.Role);
                }
            }
        }
    }
}