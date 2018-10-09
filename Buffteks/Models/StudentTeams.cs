using System;

namespace Buffteks.Models
{
    //Composite table detailing which students are on what teams as well as the students' roles
    public class StudentTeams
    {
        //COMPOSITE TABLE TYPE
        
        //Connecting the PK/FK Team ID
        public int TeamID { get; set; }
        public Team TheTeam { get; set; }

        //Connecting the PK/FK Project ID
        public int StudentID{ get; set; }
        public Student Student { get; set; }

        //Which students have which roles in the teams
        public string Role { get; set; }

        public override string ToString(){
            return "Student Teams: " + this.TeamID + " - " + this.StudentID;
        }
    }
}