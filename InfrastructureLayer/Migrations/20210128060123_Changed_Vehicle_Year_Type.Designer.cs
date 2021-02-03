﻿// <auto-generated />
using CarRentals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarRentals.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210128060123_Changed_Vehicle_Year_Type")]
    partial class Changed_Vehicle_Year_Type
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DomainLayer.Customers.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DOB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DomainLayer.Vehicles.Vehicle", b =>
                {
                    b.Property<string>("Rego")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ClassType")
                        .HasColumnType("int");

                    b.Property<string>("Colour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DailyRate")
                        .HasColumnType("float");

                    b.Property<int>("FuelType")
                        .HasColumnType("int");

                    b.Property<bool>("GPS")
                        .HasColumnType("bit");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.Property<bool>("Sunroof")
                        .HasColumnType("bit");

                    b.Property<int>("TransmissionType")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Rego");

                    b.ToTable("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
