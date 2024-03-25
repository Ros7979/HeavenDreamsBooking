using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class DiscountTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeparturedFlights_PassengerDetails_PassengerDetailId",
                table: "DeparturedFlights");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af50e8e5-4360-4aad-ae34-07144b629217");

            migrationBuilder.RenameColumn(
                name: "TicketNo",
                table: "DeparturedFlights",
                newName: "FltNo");

            migrationBuilder.RenameColumn(
                name: "ReservedBy",
                table: "DeparturedFlights",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "PassengerDetailId",
                table: "DeparturedFlights",
                newName: "PassengerDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_DeparturedFlights_PassengerDetailId",
                table: "DeparturedFlights",
                newName: "IX_DeparturedFlights_PassengerDetailsId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Fare",
                table: "Reservations",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Discount",
                table: "RegularFliers",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "DeparturedFlights",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Fare",
                table: "DeparturedFlights",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AddColumn<int>(
                name: "FlightDetailsId",
                table: "DeparturedFlights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FareLimit = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    TotalFlightsLimit = table.Column<int>(type: "int", nullable: false),
                    DiscountGiven = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0d99640-21a3-4ce3-923e-032fc707724b", "9947f9f1-7a0d-4526-9386-33d58e2e4201", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2250f58c-0ea9-4289-8d37-3d4066af3baa", "AQAAAAEAACcQAAAAEGHTwJKPyX/Uie4zEfKRsVcYs0hGFKn7FuplrCXO3QASUZUcuHIt+bgZ6KQoK8vZ4Q==", "faaca918-46a4-4e03-99e8-359e090b8c07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e41ca55-4fbd-4a8a-b00d-46e5373521ff", "AQAAAAEAACcQAAAAEP32dnhtorjBnygmxR4Q50cMObjh8i8K88gi+05GpE6OKgziggwPtOhGnF3oEpFmAw==", "35fda86f-d613-4618-ad75-4ef96b91a569" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e084309-be08-4837-9e2f-294ab753df65", "AQAAAAEAACcQAAAAEBFczrSPJ65diOGWJfg16wNHbbudEVu97j8T4voVZ+XBAg5mMQ5arQ2D4Vh5DLXVhg==", "672fea06-bcdf-4162-86b9-1efbec168d9c" });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "DiscountGiven", "FareLimit", "TotalFlightsLimit" },
                values: new object[,]
                {
                    { 1, 8.0, 5500.00m, 10 },
                    { 2, 14.0, 7500.00m, 15 }
                });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 25, 8, 18, 15, 365, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 25, 8, 18, 15, 365, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 25, 8, 18, 15, 365, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.AddForeignKey(
                name: "FK_DeparturedFlights_PassengerDetails_PassengerDetailsId",
                table: "DeparturedFlights",
                column: "PassengerDetailsId",
                principalTable: "PassengerDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeparturedFlights_PassengerDetails_PassengerDetailsId",
                table: "DeparturedFlights");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0d99640-21a3-4ce3-923e-032fc707724b");

            migrationBuilder.DropColumn(
                name: "FlightDetailsId",
                table: "DeparturedFlights");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "DeparturedFlights",
                newName: "ReservedBy");

            migrationBuilder.RenameColumn(
                name: "PassengerDetailsId",
                table: "DeparturedFlights",
                newName: "PassengerDetailId");

            migrationBuilder.RenameColumn(
                name: "FltNo",
                table: "DeparturedFlights",
                newName: "TicketNo");

            migrationBuilder.RenameIndex(
                name: "IX_DeparturedFlights_PassengerDetailsId",
                table: "DeparturedFlights",
                newName: "IX_DeparturedFlights_PassengerDetailId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Fare",
                table: "Reservations",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "RegularFliers",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "DeparturedFlights",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Fare",
                table: "DeparturedFlights",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af50e8e5-4360-4aad-ae34-07144b629217", "e6774487-898f-4b8e-a188-047a97c228ae", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b0ca77d-96fc-4794-aa99-ae6d142827d6", "AQAAAAEAACcQAAAAEGTbi6h86Hc7e0N2LWlJxZfuNyNDxx2vUflb3OCdQOQ7NqV9JEo+1wd9IR4iHDnImQ==", "99b7d97c-3327-44f6-91bb-07875c643790" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6345a13-f900-4ee6-bfc3-398b3d32b782", "AQAAAAEAACcQAAAAEF1GDTBxp+QibJrORIT3c+gSecoLF29ZQo7I2RLkVaktG2nHCc+usp4/kXDnYXDFBA==", "f2658b6f-6a9e-4c09-8d44-cd7c9bf34060" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc1fc39d-464b-4251-9d2b-41a1e32adad2", "AQAAAAEAACcQAAAAEFr6LUmcsz3jPZka5ByPkyeWTrBYUSppkBGp5VI2US3DLb2zuSIFHSSAwb+hYCuxnw==", "1b47034c-33e1-42b6-80f4-2151ed76c126" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 23, 7, 33, 43, 21, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 23, 7, 33, 43, 21, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 23, 7, 33, 43, 21, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.AddForeignKey(
                name: "FK_DeparturedFlights_PassengerDetails_PassengerDetailId",
                table: "DeparturedFlights",
                column: "PassengerDetailId",
                principalTable: "PassengerDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
