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

        // Adds data to the database When it is initially built the first time
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationID = 1,
                    FirstName = "Michael",
                    LastName = "Scott",
                    Age = 45,
                    Phone = "555-555-5555",
                    Major = "Sales",
                    CreeperStalker = false
                },
                new ApplicationResponse
                {
                    ApplicationID = 2,
                    FirstName = "Cole",
                    LastName = "Hardy",
                    Age = 20,
                    Phone = "000-900-0000",
                    Major = "Information Systems",
                    CreeperStalker = false
                }
                );
        }

    }
}

