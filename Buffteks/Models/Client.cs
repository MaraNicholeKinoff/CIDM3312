using System;

namespace Buffteks.Models
{
    //Table detailing information about the client
    public class Client 
    {
        //Clients are a type of Person
        public int ClientID { get; set; } 
        //first name
        public string FirstName { get; set; }

        //last name
        public string LastName { get; set; }

        //phone number
        public string PhoneNumber { get; set; }

        //email
        public string Email { get; set; }

        //Company Name
        public int OrganizationID { get; set; }
    }
}