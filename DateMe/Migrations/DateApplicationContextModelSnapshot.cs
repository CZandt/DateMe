﻿// <auto-generated />
using DateMe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DateMe.Migrations
{
    [DbContext(typeof(DateApplicationContext))]
    partial class DateApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("MajorID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("ApplicationID");

                    b.HasIndex("MajorID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            ApplicationID = 1,
                            Age = (byte)45,
                            CreeperStalker = false,
                            FirstName = "Michael",
                            LastName = "Scott",
                            MajorID = 1,
                            Phone = "555-555-5555"
                        },
                        new
                        {
                            ApplicationID = 2,
                            Age = (byte)20,
                            CreeperStalker = false,
                            FirstName = "Cole",
                            LastName = "Hardy",
                            MajorID = 2,
                            Phone = "000-900-0000"
                        });
                });

            modelBuilder.Entity("DateMe.Models.Major", b =>
                {
                    b.Property<int>("MajorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MajorCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("MajorName")
                        .HasColumnType("TEXT");

                    b.HasKey("MajorID");

                    b.ToTable("Majors");

                    b.HasData(
                        new
                        {
                            MajorID = 1,
                            MajorName = "Information Systems"
                        },
                        new
                        {
                            MajorID = 2,
                            MajorName = "Accounting"
                        },
                        new
                        {
                            MajorID = 3,
                            MajorName = "Aerospace Engineering"
                        },
                        new
                        {
                            MajorID = 4,
                            MajorName = "Undeclared"
                        });
                });

            modelBuilder.Entity("DateMe.Models.ApplicationResponse", b =>
                {
                    b.HasOne("DateMe.Models.Major", "Major")
                        .WithMany()
                        .HasForeignKey("MajorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
