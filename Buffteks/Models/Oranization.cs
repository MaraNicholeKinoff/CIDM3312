using System;

namespace Buffteks.Models
{
    //Table detailing information about the client
    public class Organization
    {
        public int ID { get; set; } 
        //first name
        public string OrganizationName { get; set; }

        //phone number
        public string PhoneNumber { get; set; }

        //email
        public string Email { get; set; }
        //address line 1
        public string AddLine1 { get; set; }
        //address line 2
        public string AddLine2 { get; set; }
        //city
        public string City { get; set; }
        //zipcode
        public string Zipcode { get; set; }
        //state
        public string State { get; set; }
        public override string ToString(){
            return "Organization " + this.ID + ": " + this.OrganizationName;
        }
    }
}