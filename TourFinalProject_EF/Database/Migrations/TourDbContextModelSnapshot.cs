﻿// <auto-generated />
using System;
using Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(TourDbContext))]
    partial class TourDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.Entities.DerivedEntities.BankCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(13,5)")
                        .HasColumnName("Balance");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("BankName");

                    b.Property<string>("CVC")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("CVC");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("CardNumber");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ExpirationDate");

                    b.Property<int>("TouristId")
                        .HasColumnType("int")
                        .HasColumnName("TouristId");

                    b.HasKey("Id");

                    b.HasIndex("TouristId")
                        .IsUnique();

                    b.ToTable("BankCards");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Brand");

                    b.Property<string>("CarNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("CarNumber");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Model");

                    b.Property<int>("SeatCount")
                        .HasColumnType("int")
                        .HasColumnName("SeatCount");

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasColumnName("Year");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.CarTour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("CarId");

                    b.Property<int>("TourId")
                        .HasColumnType("int")
                        .HasColumnName("TourId");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("TourId");

                    b.ToTable("CarTours");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("CarId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Phone");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Surname");

                    b.Property<int>("driverLicenseCategory")
                        .HasColumnType("int")
                        .HasColumnName("driverLicenseCategory");

                    b.HasKey("Id");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Latitude")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("decimal(7,3)")
                        .HasColumnName("Longitude");

                    b.Property<decimal>("Longitude")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("decimal(7,3)")
                        .HasColumnName("Longitude");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(13,5)")
                        .HasColumnName("Price");

                    b.Property<int?>("TourId")
                        .HasColumnType("int")
                        .HasColumnName("TourId");

                    b.Property<int?>("TouristId")
                        .HasColumnType("int")
                        .HasColumnName("TouristId");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.HasIndex("TouristId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Tour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("FinishTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("FinishTime");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("StartTime");

                    b.Property<int>("TourleaderId")
                        .HasColumnType("int")
                        .HasColumnName("TourleaderId");

                    b.HasKey("Id");

                    b.HasIndex("TourleaderId");

                    b.ToTable("Tours");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Tourist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Phone");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Surname");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Username");

                    b.HasKey("Id");

                    b.ToTable("Tourists");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Tourleader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Phone");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Surname");

                    b.HasKey("Id");

                    b.ToTable("Tourleaders");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.TourLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LocationId")
                        .HasColumnType("int")
                        .HasColumnName("LocationId");

                    b.Property<int>("TourId")
                        .HasColumnType("int")
                        .HasColumnName("TourId");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("TourId");

                    b.ToTable("TourLocations");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.BankCard", b =>
                {
                    b.HasOne("Models.Entities.DerivedEntities.Tourist", "tourist")
                        .WithOne("bankCard")
                        .HasForeignKey("Models.Entities.DerivedEntities.BankCard", "TouristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tourist");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.CarTour", b =>
                {
                    b.HasOne("Models.Entities.DerivedEntities.Car", "Car")
                        .WithMany("CarTours")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.DerivedEntities.Tour", "Tour")
                        .WithMany("CarTours")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Driver", b =>
                {
                    b.HasOne("Models.Entities.DerivedEntities.Car", "Car")
                        .WithOne("Driver")
                        .HasForeignKey("Models.Entities.DerivedEntities.Driver", "CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Ticket", b =>
                {
                    b.HasOne("Models.Entities.DerivedEntities.Tour", "Tour")
                        .WithMany("Tickets")
                        .HasForeignKey("TourId");

                    b.HasOne("Models.Entities.DerivedEntities.Tourist", "Tourist")
                        .WithMany("Tickets")
                        .HasForeignKey("TouristId");

                    b.Navigation("Tour");

                    b.Navigation("Tourist");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Tour", b =>
                {
                    b.HasOne("Models.Entities.DerivedEntities.Tourleader", "Tourleader")
                        .WithMany("Tours")
                        .HasForeignKey("TourleaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tourleader");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.TourLocation", b =>
                {
                    b.HasOne("Models.Entities.DerivedEntities.Location", "Location")
                        .WithMany("TourLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.DerivedEntities.Tour", "Tour")
                        .WithMany("TourLocations")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Car", b =>
                {
                    b.Navigation("CarTours");

                    b.Navigation("Driver")
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Location", b =>
                {
                    b.Navigation("TourLocations");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Tour", b =>
                {
                    b.Navigation("CarTours");

                    b.Navigation("Tickets");

                    b.Navigation("TourLocations");
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Tourist", b =>
                {
                    b.Navigation("Tickets");

                    b.Navigation("bankCard")
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Entities.DerivedEntities.Tourleader", b =>
                {
                    b.Navigation("Tours");
                });
#pragma warning restore 612, 618
        }
    }
}
