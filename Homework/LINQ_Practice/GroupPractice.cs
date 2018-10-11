using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace LINQ_Practice
{
    public class GroupPractice
    { 
        public static void Problem1() {
            Console.WriteLine("\nGroup Practice - Problem 1");
            using (var context = new AppDbContext()) {
                var groupedResult = context.Student.GroupBy(s => s.Role);

                foreach (var rankGroup in groupedResult)
                {
                    Console.WriteLine($"Rank Group: {rankGroup.Key}");

                    foreach(Student s in rankGroup)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
        public static void Problem2() {
            Console.WriteLine("\nGroup Practice - Problem 2");
            using (var context = new AppDbContext()) {
                var groupedResult = context.Student.OrderBy(s => s.LastName).GroupBy(s => s.Role);

                foreach (var rankGroup in groupedResult)
                {
                    Console.WriteLine($"Rank Group: {rankGroup.Key}");

                    foreach(Student s in rankGroup)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
        public static void Problem3() {
            Console.WriteLine("\nGroup Practice - Problem 3");
            using (var context = new AppDbContext()) {
                var groupedResult = context.Student.OrderBy(s => s.FirstName).GroupBy(s => s.LastName[0]);

                foreach (var rankGroup in groupedResult)
                {
                    Console.WriteLine($"Rank Group: {rankGroup.Key}");

                    foreach(Student s in rankGroup)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }       
    }
}