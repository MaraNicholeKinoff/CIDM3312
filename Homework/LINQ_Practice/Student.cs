using System;

namespace LINQ_Practice
{
    public class Student
    {
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
        public string Role { get; set; }

        //Taken CIDM3315
        public bool Taken3350 { get; set; }

        public override string ToString(){
            return this.FirstName + " " + this.LastName;
        }
    }

}