using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class ReservationController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightsCanseled_ProcessedBies_ProcessedById",
                table: "FlightsCanseled");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ProcessedBies_FlightDetailsId",
                table: "Reservations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1501c14-18dd-4859-8484-bd7d294b2876");

            migrationBuilder.DropColumn(
                name: "ProcessedById",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "TicketNo",
                table: "Reservations",
                newName: "FltNo");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Reservations",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightsCanseled_ProcessedBies_ProcessedById",
                table: "FlightsCanseled",
                column: "ProcessedById",
                principalTable: "ProcessedBies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightsCanseled_ProcessedBies_ProcessedById",
                table: "FlightsCanseled");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af50e8e5-4360-4aad-ae34-07144b629217");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "FltNo",
                table: "Reservations",
                newName: "TicketNo");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Reservations",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddColumn<int>(
                name: "ProcessedById",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1501c14-18dd-4859-8484-bd7d294b2876", "4c96512a-14c5-4fb1-a38a-6656a2e6dbbe", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba1f4473-1595-4aa7-a3b7-8fc01b19f924", "AQAAAAEAACcQAAAAEFJpYkmSG0YDupne77jk8EgUdZpKddZMoN2MHwwJGRVQnYE1i2xXSzja+3wseOxtlQ==", "410b751e-3800-4497-af38-35835ae3fc4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b7dedc8-2f33-4c95-9a5d-1ab38d3c2146", "AQAAAAEAACcQAAAAEG66VgReoiy/VIEY+PTsTpdw4hfgTiu3TktyHY5gh4UvGNd3x1xVfrUf33yOIKfQXQ==", "b2155ca0-eb43-4899-a994-9d54ae3f567e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "301fbfca-3fb4-44ca-9bb3-cca685942998", "AQAAAAEAACcQAAAAEM71zmDRC8E9oZacq5odrd6qniHF1BZF6EN6w7ybmISHf8d1YWVdnpfBv7tANPTvug==", "3aaa492a-42df-417a-a903-d7b54a396db4" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 19, 21, 55, 21, 102, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 19, 21, 55, 21, 102, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 19, 21, 55, 21, 102, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.AddForeignKey(
                name: "FK_FlightsCanseled_ProcessedBies_ProcessedById",
                table: "FlightsCanseled",
                column: "ProcessedById",
                principalTable: "ProcessedBies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ProcessedBies_FlightDetailsId",
                table: "Reservations",
                column: "FlightDetailsId",
                principalTable: "ProcessedBies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
