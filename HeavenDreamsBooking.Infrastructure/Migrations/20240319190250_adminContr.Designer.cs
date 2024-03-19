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
    [Migration("20240319190250_adminContr")]
    partial class adminContr
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
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("PassengerDetailId")
                        .HasColumnType("int");

                    b.Property<string>("ReservedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool?>("TicketConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("TicketNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("PassengerDetailId");

                    b.ToTable("DeparturedFlights");
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.FlightCanseled", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CanselationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProcessedById")
                        .HasColumnType("int");

                    b.Property<int>("Refund")
                        .HasColumnType("int");

                    b.Property<string>("TicketNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("ProcessedById");

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
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("FareEconomy")
                        .HasColumnType("decimal(5,2)");

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
                            LaunchDate = new DateTime(2024, 3, 19, 21, 2, 50, 586, DateTimeKind.Local).AddTicks(3234),
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
                            LaunchDate = new DateTime(2024, 3, 19, 21, 2, 50, 586, DateTimeKind.Local).AddTicks(3275),
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
                            LaunchDate = new DateTime(2024, 3, 19, 21, 2, 50, 586, DateTimeKind.Local).AddTicks(3278),
                            SeatsBusines = 4,
                            SeatsEconomy = 80
                        });
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

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.ProcessedBy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ProcessedBies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PhoneNumber = "+359878907060",
                            UserId = "bsm12345-b345-s678-m123-b1s2m3456789"
                        },
                        new
                        {
                            Id = 2,
                            PhoneNumber = "+359778204906",
                            UserId = "adm12345-a345-d678-m321-a3d2m1987654"
                        },
                        new
                        {
                            Id = 3,
                            PhoneNumber = "+359778204906",
                            UserId = "empu1234-em45-u123-r864-e3m2p1u87652"
                        });
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.RegularFlier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(5,2)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<decimal>("Fare")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("FlightDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("ProcessedById")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool?>("TicketConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("TicketNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("FlightDetailsId");

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
                            Id = "029cef0e-c4c6-4ade-ae94-fc0627690d97",
                            ConcurrencyStamp = "01992075-684e-4f88-ac76-b88b84ddf181",
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
                            ConcurrencyStamp = "51d0dc3f-e595-47ea-8d51-bfbec667efc5",
                            Email = "isbusinessmanager@mail.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "isbusinessmanager@mail.bg",
                            NormalizedUserName = "Ivan Stamenov",
                            PasswordHash = "AQAAAAEAACcQAAAAELM5fOT2vwW448keN4/rmKVjSeSwcJ6itHWoOeUzZv93LxXKVPM83ebgZwf7rcJpMw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3908d861-a6cd-4c7e-8244-e442622cab57",
                            TwoFactorEnabled = false,
                            UserName = "Ivan Stamenov"
                        },
                        new
                        {
                            Id = "adm12345-a345-d678-m321-a3d2m1987654",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "55735e24-cf29-4fe1-9c98-a84d0dbbfe76",
                            Email = "pvadminuser@mail.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "isadminuser@mail.bg",
                            NormalizedUserName = "Petar Vasilev",
                            PasswordHash = "AQAAAAEAACcQAAAAEBxrSaxCst+oTfuDDBFTMt040ULzX3lFrgkUGxaPgoAnsbLcYYXeuiGBCiaejyV+Pw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f9d09c62-e8c0-476a-b6a6-7d7ea451906d",
                            TwoFactorEnabled = false,
                            UserName = "Petar Vasilev"
                        },
                        new
                        {
                            Id = "empu1234-em45-u123-r864-e3m2p1u87652",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "28c8a781-3c8d-4ad5-abab-e8da0b8490e0",
                            Email = "spemployuser@mail.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "spemployuser@mail.bg",
                            NormalizedUserName = "Svetla Peteva",
                            PasswordHash = "AQAAAAEAACcQAAAAEBWvrqJui5mTXe7RngeJ7SiKhsfqw4I3w7eZDqeyrJGjXi8MfeoPxBEZhjUgokXUug==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9e171b94-b6ab-4b3e-a425-31944b0775c2",
                            TwoFactorEnabled = false,
                            UserName = "Svetla Peteva"
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
                        .HasForeignKey("PassengerDetailId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PassengerDetail");
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.FlightCanseled", b =>
                {
                    b.HasOne("HeavenDreamsBooking.Infrastructure.Data.Models.ProcessedBy", "ProcessedBy")
                        .WithMany()
                        .HasForeignKey("ProcessedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProcessedBy");
                });

            modelBuilder.Entity("HeavenDreamsBooking.Infrastructure.Data.Models.ProcessedBy", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
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

                    b.HasOne("HeavenDreamsBooking.Infrastructure.Data.Models.ProcessedBy", "ProcessedBy")
                        .WithMany()
                        .HasForeignKey("FlightDetailsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FlightDetail");

                    b.Navigation("ProcessedBy");
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
