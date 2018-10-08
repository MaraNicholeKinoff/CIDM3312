using System;

namespace Buffteks.Models
{
    //Table detailing aspects of the projects, linked to which clients and teams are on what projects.
    public class Project 
    {
        //PK
        public int ProjectID { get; set; }

        //client = FK
        public int ClientID{ get; set; }
        public Client Client { get; set; }

        //name
        public string ProjectName { get; set; }

        //estimated hours
        public int EstimatedHours { get; set; }

        //deadline (DATETIME data type)
        public DateTime Deadline { get; set; }

        //team = FK
        public int TeamID { get; set; }
        public Team Team { get; set; }
    }
}