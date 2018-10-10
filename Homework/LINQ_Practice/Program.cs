using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seed Database
            SeedCommands.CreateSeedData();
            
            //Where Practice
            WherePractice.Problem1();
            WherePractice.Problem2();
            WherePractice.Problem3();
            WherePractice.Problem4();
            WherePractice.Problem5();

            //Find Practice
            FindPractice.Problem1();
            FindPractice.Problem2();
            FindPractice.Problem3();
            FindPractice.Problem4();
            FindPractice.Problem5();

            //Sort Practice


            //Group Practice
        }
    }
}
