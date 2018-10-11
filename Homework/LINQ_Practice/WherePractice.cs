using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace LINQ_Practice
{
    public class WherePractice
    { 
        public static void Problem1() {
            Console.WriteLine("\nWhere Practice - Problem 1");
            using (var context = new AppDbContext()) {
                var students = context.Student.ToList();
                foreach(Student s in students)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void Problem2() {
            //Using Method Syntax
            Console.WriteLine("\nWhere Practice - Problem 2");
            using (var context = new AppDbContext()) {
                var students = context.Student.ToList();
                var notSeniors = students.Where(s => s.Role != "Senior");
                foreach(Student s in notSeniors)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void Problem3() {
            //Using Query Syntax
            Console.WriteLine("\nWhere Practice - Problem 3");
            using (var context = new AppDbContext()) {
                var studentsFilteredFName = from s in context.Student
                                            where s.FirstName[0] >= 'M'
                                            select s;
                foreach (var s in studentsFilteredFName) {
                    Console.WriteLine(s);
                }
            }
        }
        public static void Problem4() {
            //Using Query Syntax
            Console.WriteLine("\nWhere Practice - Problem 4");
            using (var context = new AppDbContext()) {
                var studentsFilteredName = from s in context.Student
                                            where s.LastName[0] <= 'L' && s.FirstName.Length > 6
                                            select s;
                foreach (var s in studentsFilteredName) {
                    Console.WriteLine(s);
                }
            }
        }
        public static void Problem5() {
            //Using Method Syntax
            Console.WriteLine("\nWhere Practice - Problem 5");
            using (var context = new AppDbContext()) {
                var students = context.Student.ToList();
                var takenClass = students.Where(s => s.Taken3350 != false);
                foreach(Student s in takenClass)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}