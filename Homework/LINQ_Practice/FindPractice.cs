using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace LINQ_Practice
{
    public class FindPractice
    { 
        public static void Problem1() {
            //Method Syntax
            Console.WriteLine("\nFind Practice - Problem 1");
            using (var context = new AppDbContext()) {
                var students = context.Student.ToList();
                var findJohn = students.Where(s => s.FirstName == "John");
                foreach(Student s in findJohn)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void Problem2() {
            //Method Syntax
            Console.WriteLine("\nFind Practice - Problem 2");
            using (var context = new AppDbContext()) {
                var students = context.Student.ToList();
                var findJohn = students.Where(s => s.FirstName == "Alexander");
                foreach(Student s in findJohn)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void Problem3() {
            //Query Syntax
            Console.WriteLine("\nFind Practice - Problem 3");
            using (var context = new AppDbContext()) {
                var students = context.Student.ToList();
                var findShortFName = (from s in context.Student
                                            orderby s.FirstName.Length
                                            select s).Take(1);
                foreach (var s in findShortFName) {
                    Console.WriteLine(s);
                }
            }
        }
        public static void Problem4() {
            //Query and Method Syntax
            Console.WriteLine("\nFind Practice - Problem 4");
            using (var context = new AppDbContext()) {
                var students = context.Student.ToList();
                var findShortLName = (from s in context.Student
                                            orderby s.LastName.Length
                                            select s).Take(1);
                foreach (var s in findShortLName) {
                    Console.WriteLine(s);
                }
            }
        }
        public static void Problem5() {
            //Query and Method Syntax
            Console.WriteLine("\nFind Practice - Problem 5");
            using (var context = new AppDbContext()) {
                var students = context.Student.ToList();
                var findShortLName = (from s in context.Student
                                            orderby s.LastName.Length ascending, s.FirstName.Length descending
                                            select s).Take(1);
                foreach (var s in findShortLName) {
                    Console.WriteLine(s);
                }
            }
        }
    }
}