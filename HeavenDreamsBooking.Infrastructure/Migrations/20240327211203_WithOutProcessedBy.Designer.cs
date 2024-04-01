﻿// <auto-generated />
using System;
using HeavenDreamsBooking.Infrastrucure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    [DbContext(typeof(HeavenDbContext))]
    [Migration("20240327211203_WithOutProcessedBy")]
    partial class WithOutProcessedBy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.DeparturedFlight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClassOfRes")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("DateOfJorney")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfRes")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<decimal>("Fare")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("FlightDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("FltNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("PassengerDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("TicketConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PassengerDetailsId");

                    b.ToTable("DeparturedFlights");
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("DiscountGiven")
                        .HasColumnType("float");

                    b.Property<decimal>("FareLimit")
                        .HasColumnType("decimal(7,2)");

                    b.Property<int>("TotalFlightsLimit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Discounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiscountGiven = 8.0,
                            FareLimit = 5500.00m,
                            TotalFlightsLimit = 10
                        },
                        new
                        {
                            Id = 2,
                            DiscountGiven = 14.0,
                            FareLimit = 7500.00m,
                            TotalFlightsLimit = 15
                        });
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.FlightCanseled", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CanselationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfJorney")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("FltNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<float>("Refund")
                        .HasColumnType("real");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("FlightsCanseled");
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.FlightDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AircraftType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ArrTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("FareBusines")
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("FareEconomy")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("FltNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Flight image url");

                    b.Property<DateTime>("LaunchDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SeatsBusines")
                        .HasColumnType("int");

                    b.Property<int>("SeatsEconomy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FlightDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AircraftType = "Airbus a380",
                            ArrTime = new DateTime(2024, 8, 24, 10, 35, 0, 0, DateTimeKind.Unspecified),
                            DepTime = new DateTime(2024, 8, 23, 14, 35, 0, 0, DateTimeKind.Unspecified),
                            Destination = "Барселона",
                            FareBusines = 180.00m,
                            FareEconomy = 125.40m,
                            FltNo = "SOF-BCN",
                            From = "София",
                            ImageUrl = "https://wallpaperaccess.com/full/1322174.jpg",
                            LaunchDate = new DateTime(2024, 3, 27, 23, 12, 2, 595, DateTimeKind.Local).AddTicks(6040),
                            SeatsBusines = 30,
                            SeatsEconomy = 50
                        },
                        new
                        {
                            Id = 2,
                            AircraftType = "Airbus a320",
                            ArrTime = new DateTime(2024, 6, 14, 16, 22, 0, 0, DateTimeKind.Unspecified),
                            DepTime = new DateTime(2024, 6, 14, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Destination = "Ларнака",
                            FareBusines = 280.00m,
                            FareEconomy = 200.00m,
                            FltNo = "SOF-LCA",
                            From = "София",
                            ImageUrl = "https://www.goatsontheroad.com/wp-content/uploads/2022/11/Malindi-Beach-in-Limassol.jpeg",
                            LaunchDate = new DateTime(2024, 3, 27, 23, 12, 2, 595, DateTimeKind.Local).AddTicks(6095),
                            SeatsBusines = 24,
                            SeatsEconomy = 40
                        },
                        new
                        {
                            Id = 3,
                            AircraftType = "Boeing 747",
                            ArrTime = new DateTime(2024, 10, 10, 23, 30, 0, 0, DateTimeKind.Unspecified),
                            DepTime = new DateTime(2024, 10, 10, 6, 30, 0, 0, DateTimeKind.Unspecified),
                            Destination = "Атина",
                            FareBusines = 500.00m,
                            FareEconomy = 314.00m,
                            FltNo = "SOF-ATH",
                            From = "София",
                            ImageUrl = "https://th.bing.com/th/id/OIP.gtnO8Z0v_QVMykrG4JUJygHaE8?rs=1&pid=ImgDetMain",
                            LaunchDate = new DateTime(2024, 3, 27, 23, 12, 2, 595, DateTimeKind.Local).AddTicks(6098),
                            SeatsBusines = 4,
                            SeatsEconomy = 80
                        });
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.FlightStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfJorney")
                        .HasColumnType("datetime2");

                    b.Property<int>("FlightDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("FltNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("StatusBusiness")
                        .HasColumnType("int");

                    b.Property<int>("StatusEconomy")
                        .HasColumnType("int");

                    b.Property<int>("WaitListedBusiness")
                        .HasColumnType("int");

                    b.Property<int>("WaitListedEconomy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FlightDetailsId")
                        .IsUnique();

                    b.ToTable("FlightStatus");
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.PassengerDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<decimal>("FareCollected")
                        .HasColumnType("decimal(7,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("TotalTimesFlown")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PassengerDetails");
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.RegularFlier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("PassengerDetailId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PassengerDetailId")
                        .IsUnique();

                    b.ToTable("RegularFliers");
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClassOfRes")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("DateOfJorney")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfRes")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<decimal>("Fare")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("FlightDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("FltNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("TicketConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FlightDetailsId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "69c8ebe5-9fae-4009-8fa5-4a78c4ab2b35",
                            ConcurrencyStamp = "ad102867-d405-48c7-80cc-e2d3560a1fc6",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "bsm12345-b345-s678-m123-b1s2m3456789",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "314fcf5c-55f5-4d36-8bbb-c561f6168f3e",
                            Email = "isbusinessmanager@mail.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "isbusinessmanager@mail.bg",
                            NormalizedUserName = "isbusinessmanager@mail.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEF1qGQ2ObCYbFEgZxtYPcLLNhD38tWl4ZMbtMKyyYySkjadVsZtdt6wncHzOGH0cyw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9ded2444-1f35-4571-95d8-dfc77987b162",
                            TwoFactorEnabled = false,
                            UserName = "isbusinessmanager@mail.bg"
                        },
                        new
                        {
                            Id = "adm12345-a345-d678-m321-a3d2m1987654",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1cf2decc-04e3-4c59-9d8b-f7f834868e9d",
                            Email = "pvadminuser@mail.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "pvadminuser@mail.bg",
                            NormalizedUserName = "pvadminuser@mail.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEFztty7noF4w6bB85tMu7MawPGFm5pitnFGDj3rOvtRRvgDOmr93lQK9FuEHE4Npnw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "50dc4d66-8f32-498d-bae7-7cc35c8b6817",
                            TwoFactorEnabled = false,
                            UserName = "pvadminuser@mail.bg"
                        },
                        new
                        {
                            Id = "empu1234-em45-u123-r864-e3m2p1u87652",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "680d0129-a10d-4cf2-9339-5d32203aebbd",
                            Email = "spemployuser@mail.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "spemployuser@mail.bg",
                            NormalizedUserName = "spemployuser@mail.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEC/38m2BssRvIc2tROcDwf0MK6egpqOJA6XVmjH4SKkYJQWL4Q7FglAMMb1rGM3eQA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "eacdebf6-c00c-45b6-87eb-833c286105f8",
                            TwoFactorEnabled = false,
                            UserName = "spemployuser@mail.bg"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.DeparturedFlight", b =>
                {
                    b.HasOne("HeavenDreamsBooking.Infrastructure.Data.Models.PassengerDetail", "PassengerDetail")
                        .WithMany("DeparturedFlights")
                        .HasForeignKey("PassengerDetailsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PassengerDetail");
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.FlightCanseled", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.FlightStatus", b =>
                {
                    b.HasOne("HeavenDreamsBooking.Infrastructure.Data.Models.FlightDetail", "FlightDetail")
                        .WithOne("FlightStatus")
                        .HasForeignKey("HeavenDreamsBooking.Infrastructure.Data.Models.FlightStatus", "FlightDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FlightDetail");
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.RegularFlier", b =>
                {
                    b.HasOne("HeavenDreamsBooking.Infrastructure.Data.Models.PassengerDetail", "PassengerDetail")
                        .WithOne("RegularFlier")
                        .HasForeignKey("HeavenDreamsBooking.Infrastructure.Data.Models.RegularFlier", "PassengerDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PassengerDetail");
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.Reservation", b =>
                {
                    b.HasOne("HeavenDreamsBooking.Infrastructure.Data.Models.FlightDetail", "FlightDetail")
                        .WithMany("Reservations")
                        .HasForeignKey("FlightDetailsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FlightDetail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.FlightDetail", b =>
                {
                    b.Navigation("FlightStatus");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.PassengerDetail", b =>
                {
                    b.Navigation("DeparturedFlights");

                    b.Navigation("RegularFlier");
                });
#pragma warning restore 612, 618
        }
    }
}
