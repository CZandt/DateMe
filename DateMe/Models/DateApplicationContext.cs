using System;
using Microsoft.EntityFrameworkCore;
namespace DateMe.Models
{
    public class DateApplicationContext : DbContext
    {
        //Constructor
        public DateApplicationContext(DbContextOptions<DateApplicationContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<ApplicationResponse> responses { get; set; }
        public DbSet<Major> Majors { get; set; }

        // Adds data to the database When it is initially built the first time
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Major>().HasData(
                    new Major
                    {
                        MajorID = 1,
                        MajorName = "Information Systems"
                    },
                    new Major { MajorID = 2, MajorName = "Accounting"},
                    new Major { MajorID = 3, MajorName = "Aerospace Engineering"},
                    new Major { MajorID = 4, MajorName = "Undeclared" }

                );
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationID = 1,
                    FirstName = "Michael",
                    LastName = "Scott",
                    Age = 45,
                    Phone = "555-555-5555",
                    MajorID = 2,
                    CreeperStalker = false
                },
                new ApplicationResponse
                {
                    ApplicationID = 2,
                    FirstName = "Cole",
                    LastName = "Hardy",
                    Age = 20,
                    Phone = "000-900-0000",
                    MajorID = 1,
                    CreeperStalker = false
                }
                );

            
        }

    }
}

