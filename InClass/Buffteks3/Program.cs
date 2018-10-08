using System;

namespace Buffteks3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writing seed data into the database
            using(var db = new AppDbContext())
            {
                //This says no matter what, delete it and then create it
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                Student s = new Student() 
                {
                    FirstName = "Jeff",
                    LastName = "Babb",
                    PhoneNumber = "123-456-7890",
                    Email = "",
                    Role = "Front End Developer"
                };
                db.Student.Add(s);
                db.SaveChanges();
            }
        }
    }
}
