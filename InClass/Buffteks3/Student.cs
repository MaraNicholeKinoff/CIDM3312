using System;

namespace  Buffteks3
{
    public class Student 
    {
        //PK
        public int StudentID { get; set; }
        //first name
        public string FirstName { get; set; }
        //last name
        public string LastName { get; set; }
        //phone number
        public string PhoneNumber { get; set; }
        //email
        public string Email { 
            get
            {
                return this.Email;
            } 
            set
            {
                this.Email = value;
            }
        }
        //Role
        public string Role { get; set; }
    }
}