using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

//using Buffteks.Models;

namespace Buffteks.Models
{
    public class EFIADBContext : DbContext
    {
        //The connection string is used by the SQL Server database provider to find the database
        private const string ConnectionString = @"Data Source=EfCoreDb.db";
                    

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            //Using the SQLite database provider’s UseSqlServer command sets up the options ready for creating the applications’s DBContext
            optionsBuilder.UseSqlite(ConnectionString); //#B
        }

        //This creates a student table and gives access to the student class (Students.cs)
        public DbSet<Student> Student { get; set; }
        //This creates a client table and gives access to the client class (Client.cs)
        public DbSet<Client> Client { get; set; }
        public DbSet<FacultySponsor> FacultySponsor { get; set; }
        public DbSet<Team> Team { get; set; }
        //public DbSet<StudentTeams> StudentTeams { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<StudentTeams> StudentTeams { get; set; }
        public DbSet<ClientOrganization> ClientOrganization { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentTeams>()
                .HasKey(st => new { st.TeamID, st.StudentID });
            modelBuilder.Entity<ClientOrganization>()
                .HasKey(co => new { co.ClientID, co.OrganizationID });
        }
    }

}