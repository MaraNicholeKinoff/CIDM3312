using System;

namespace Buffteks.Models
{
    //Composite table detailing which students are on what teams as well as the students' roles
    public class ClientOrganization
    {
        //COMPOSITE TABLE TYPE
        
        //Connecting the PK/FK Team ID
        public int ClientID { get; set; }

        //Connecting the PK/FK Project ID
        public int OrganizationID{ get; set; }
        
        public Client Client { get; set; }
        public Organization Organization { get; set; }
        public override string ToString(){
            return "Client Organization: " + this.ClientID + " - " + this.OrganizationID;
        }
    }
}