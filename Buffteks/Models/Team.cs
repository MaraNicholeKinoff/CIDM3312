using System;

namespace Buffteks.Models
{
    //Table detailing the teams in Buffteks
    public class Team
    {
        //PK (This will be the Team ID FK in other models)
        public int TeamID { get; set; }
        
        //Team name
        public string TeamName { get; set; }
        public override string ToString(){
            return "Team " + this.TeamID + ": " + this.TeamName;
        }
        
        //team leader - FK to a student 
        // public int LeaderStudentID { get; set; } 
        // public Student Student { get; set; }        
    }
}