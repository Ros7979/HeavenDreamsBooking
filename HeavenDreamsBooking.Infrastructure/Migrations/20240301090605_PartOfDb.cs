using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class PartOfDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FltNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DepTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AircraftType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SeatsBusines = table.Column<int>(type: "int", nullable: false),
                    SeatsFirstClass = table.Column<int>(type: "int", nullable: false),
                    SeatsEconomy = table.Column<int>(type: "int", nullable: false),
                    FareBusines = table.Column<float>(type: "real", nullable: false),
                    FareFirstClass = table.Column<float>(type: "real", nullable: false),
                    FareEconomy = table.Column<float>(type: "real", nullable: false),
                    LaunchDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcessedBies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessedBies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessedBies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightsCanseled",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Refund = table.Column<int>(type: "int", nullable: false),
                    ProcessedById = table.Column<int>(type: "int", nullable: false),
                    CanselationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightsCanseled", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlightsCanseled_ProcessedBies_ProcessedById",
                        column: x => x.ProcessedById,
                        principalTable: "ProcessedBies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FlightDetailsId = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    DateOfJorney = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassOfRes = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Fare = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ProcessedById = table.Column<int>(type: "int", nullable: false),
                    DateOfRes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicketConfirmed = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_FlightDetails_FlightDetailsId",
                        column: x => x.FlightDetailsId,
                        principalTable: "FlightDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_ProcessedBies_FlightDetailsId",
                        column: x => x.FlightDetailsId,
                        principalTable: "ProcessedBies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightsCanseled_ProcessedById",
                table: "FlightsCanseled",
                column: "ProcessedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessedBies_UserId",
                table: "ProcessedBies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_FlightDetailsId",
                table: "Reservations",
                column: "FlightDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightsCanseled");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "FlightDetails");

            migrationBuilder.DropTable(
                name: "ProcessedBies");
        }
    }
}
