using System;
using System.Collections.Generic;

namespace Buffteks.Models
{
    //Table detailing students in Buffteks
    public class Student
    {
        //Students are a type of Person (Inheritence)
        public int StudentID { get; set; } 
        //first name
        public string FirstName { get; set; }

        //last name
        public string LastName { get; set; }

        //phone number
        public string PhoneNumber { get; set; }

        //email
        public string Email { get; set; }

        //major
        public string Major { get; set; }
        public override string ToString(){
            return "Student " + this.StudentID + ": " + this.FirstName + " " + this.LastName + " - " + this.Major;
        }
    }
}