using System;

namespace Buffteks.Models
{
    //Table detailing information about the client
    public class Organization
    {
        //Clients are a type of Person
        public int OganizationID { get; set; } 
        //first name
        public string OrganizationName { get; set; }

        //phone number
        public string PhoneNumber { get; set; }

        //email
        public string Email { get; set; }
    }
}