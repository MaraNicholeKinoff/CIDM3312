using System;

namespace Buffteks.Models
{
    //Table detailing information about the faculty sponsor for Buffteks
    public class FacultySponsor 
    {
        //PK
        public int ID { get; set; } 
        //first name
        public string FirstName { get; set; }

        //last name
        public string LastName { get; set; }

        //phone number
        public string PhoneNumber { get; set; }

        //email
        public string Email { get; set; }

        //Department Name
        public string DepartmentName { get; set; }
        
        public override string ToString(){
            return "Advisor " + this.ID + ": " + this.FirstName + " " + this.LastName + " - " + this.DepartmentName;
        }
    }
}