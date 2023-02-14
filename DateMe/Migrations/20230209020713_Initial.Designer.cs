﻿// <auto-generated />
using DateMe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DateMe.Migrations
{
    [DbContext(typeof(DateApplicationContext))]
    [Migration("20230209020713_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("DateMe.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CreeperStalker")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Major")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("ApplicationID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            ApplicationID = 1,
                            Age = (byte)45,
                            CreeperStalker = false,
                            FirstName = "Michael",
                            LastName = "Scott",
                            Major = "Sales",
                            Phone = "555-555-5555"
                        },
                        new
                        {
                            ApplicationID = 2,
                            Age = (byte)20,
                            CreeperStalker = false,
                            FirstName = "Cole",
                            LastName = "Hardy",
                            Major = "Information Systems",
                            Phone = "000-900-0000"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
