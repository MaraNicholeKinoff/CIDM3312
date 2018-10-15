using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace Buffteks.Models
{
    public class UpdateCommands
    {
        public static void UpdateClientOrganizationRecords() {
            using (var context = new EFIADBContext()) {
                var corgs = context.ClientOrganization.ToList();
                foreach(ClientOrganization c in corgs)
                {
                    Console.WriteLine(c);
                }

                Console.Write("Enter the ClientID number in the record you wish to update: ");
                var userClientNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the OrganizationID number in the record you wish to update: ");
                var userOrgNum = Convert.ToInt32(Console.ReadLine());

                var findCorg = corgs.Where(co => co.ClientID == userClientNum && co.OrganizationID == userOrgNum);
                foreach(ClientOrganization co in findCorg)
                {
                    Console.WriteLine($"The ClientID and OrganizationID record you wish to update is: {co.ClientID} and {co.OrganizationID}");
                    Console.Write("Enter the ClientID number in the record you wish to update the record to: ");
                    var userClientNumUpdate = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the OrganizationID number in the record you wish to update the record to: ");
                    var userOrgNumUpdate = Convert.ToInt32(Console.ReadLine());
                    co.ClientID = userClientNumUpdate;
                    co.OrganizationID = userOrgNumUpdate;
                    Console.WriteLine($"The ClientID and OrganizationID updated record is: {co.ClientID} and {co.OrganizationID}");
                }
                context.SaveChanges();
            }
        }
        public static void UpdateStudentTeamsRecords() {
            using (var context = new EFIADBContext()) {
                var steams = context.StudentTeams.ToList();
                foreach(StudentTeams st in steams)
                {
                    Console.WriteLine(st);
                }

                Console.Write("Enter the StudentID number in the record you wish to update: ");
                var userStudentNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the TeamID number in the record you wish to update: ");
                var userTeamNum = Convert.ToInt32(Console.ReadLine());

                var findSteam = steams.Where(co => co.StudentID == userStudentNum && co.TeamID == userTeamNum);
                foreach(StudentTeams co in findSteam)
                {
                    Console.WriteLine($"The StudentID and TeamID record you wish to update is: {co.StudentID} and {co.TeamID}");
                    Console.Write("Enter the StudentID number in the record you wish to update the record to: ");
                    var userStudentNumUpdate = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the TeamID number in the record you wish to update the record to: ");
                    var userTeamNumUpdate = Convert.ToInt32(Console.ReadLine());
                    co.StudentID = userStudentNumUpdate;
                    co.TeamID = userTeamNumUpdate;
                    Console.WriteLine($"The StudentID and TeamID updated record is: {co.StudentID} and {co.TeamID}");
                }
                context.SaveChanges();
            }
        }
    }
}