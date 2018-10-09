using System;

namespace Buffteks.Models
{
    //Composite table detailing which teams are woring on what projects.
    public class ProjectTeams
    {     
        //Connecting the PK/FK Team ID
        public int TeamID { get; set; }
        public Team Team { get; set; }

        //Connecting the PK/FK Project ID
        public int ProjectID{ get; set; }
        public Project Project { get; set; }

        public override string ToString(){
            return "Project Teams: " + this.TeamID + " - " + this.ProjectID;
        }
    }
}