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
        
        public Team Team { get; set; }
        public Student Student { get; set; }

        //Which students have which roles in the teams
        public string Role { get; set; }

        public override string ToString(){
            return "Student Teams: " + this.TeamID + " - " + this.StudentID;
        }
    }
}