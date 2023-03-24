﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Office_Seat_Booking_DLL;

#nullable disable

namespace Office_Seat_Booking_DLL.Migrations
{
    [DbContext(typeof(OfficeDbContext))]
    [Migration("20230323122525_seatbooking")]
    partial class seatbooking
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Office_Seat_Booking_Entity.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<bool>("Emp_Status")
                        .HasColumnType("bit");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("Food_Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("From_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Seat_No")
                        .HasColumnType("int");

                    b.Property<int>("Seat_No1")
                        .HasColumnType("int");

                    b.Property<DateTime>("Shift_Time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("To_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type_Of_Request")
                        .HasColumnType("int");

                    b.Property<bool>("Vehicle")
                        .HasColumnType("bit");

                    b.Property<int>("booking_Status")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("Seat_No1");

                    b.ToTable("booking");
                });

            modelBuilder.Entity("Office_Seat_Booking_Entity.Employee", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpID"));

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNo")
                        .HasColumnType("int");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secret_Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpID");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("Office_Seat_Booking_Entity.Floor", b =>
                {
                    b.Property<int>("FloorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FloorID"));

                    b.Property<string>("FloorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FloorID");

                    b.ToTable("floor");
                });

            modelBuilder.Entity("Office_Seat_Booking_Entity.Parking", b =>
                {
                    b.Property<int>("ParkingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParkingID"));

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<string>("ParkingType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParkingID");

                    b.HasIndex("BookingID");

                    b.ToTable("parking");
                });

            modelBuilder.Entity("Office_Seat_Booking_Entity.Seat", b =>
                {
                    b.Property<int>("Seat_No")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Seat_No"));

                    b.Property<int>("FloorID")
                        .HasColumnType("int");

                    b.HasKey("Seat_No");

                    b.HasIndex("FloorID");

                    b.ToTable("seat");
                });

            modelBuilder.Entity("Office_Seat_Booking_Entity.Booking", b =>
                {
                    b.HasOne("Office_Seat_Booking_Entity.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Office_Seat_Booking_Entity.Seat", "seat")
                        .WithMany()
                        .HasForeignKey("Seat_No1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");

                    b.Navigation("seat");
                });

            modelBuilder.Entity("Office_Seat_Booking_Entity.Parking", b =>
                {
                    b.HasOne("Office_Seat_Booking_Entity.Booking", "booking")
                        .WithMany()
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("booking");
                });

            modelBuilder.Entity("Office_Seat_Booking_Entity.Seat", b =>
                {
                    b.HasOne("Office_Seat_Booking_Entity.Floor", "floor")
                        .WithMany()
                        .HasForeignKey("FloorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("floor");
                });
#pragma warning restore 612, 618
        }
    }
}
