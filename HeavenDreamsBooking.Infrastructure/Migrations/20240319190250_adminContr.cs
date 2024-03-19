using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class adminContr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "029cef0e-c4c6-4ade-ae94-fc0627690d97", "01992075-684e-4f88-ac76-b88b84ddf181", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55735e24-cf29-4fe1-9c98-a84d0dbbfe76", "AQAAAAEAACcQAAAAEBxrSaxCst+oTfuDDBFTMt040ULzX3lFrgkUGxaPgoAnsbLcYYXeuiGBCiaejyV+Pw==", "f9d09c62-e8c0-476a-b6a6-7d7ea451906d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51d0dc3f-e595-47ea-8d51-bfbec667efc5", "AQAAAAEAACcQAAAAELM5fOT2vwW448keN4/rmKVjSeSwcJ6itHWoOeUzZv93LxXKVPM83ebgZwf7rcJpMw==", "3908d861-a6cd-4c7e-8244-e442622cab57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28c8a781-3c8d-4ad5-abab-e8da0b8490e0", "AQAAAAEAACcQAAAAEBWvrqJui5mTXe7RngeJ7SiKhsfqw4I3w7eZDqeyrJGjXi8MfeoPxBEZhjUgokXUug==", "9e171b94-b6ab-4b3e-a425-31944b0775c2" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 19, 21, 2, 50, 586, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 19, 21, 2, 50, 586, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 19, 21, 2, 50, 586, DateTimeKind.Local).AddTicks(3278));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "029cef0e-c4c6-4ade-ae94-fc0627690d97");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dd06286-da6a-471f-b1ae-204524976360", "AQAAAAEAACcQAAAAEHe8I6A8YDw2Ru51/8U3/o5V/ul3OG06MwrFZRhgyDZP0WNCIy2u1EW0KwjgMyrmAQ==", "8696c3a6-ff17-4b43-a498-64cdcab9f087" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47c530c2-a0d9-42e1-ae3b-13951d38f1b1", "AQAAAAEAACcQAAAAEDhX83ajy4IjqAjCTQLUxU4jDaSyMImY5viIAivxyCLfBXgiT7Lta+vZ1mHkVDILjQ==", "55ddcabc-45bc-410d-9b32-d04b47db3ae9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e77b0a37-0c5e-4e8a-a4ea-0f939e11c09b", "AQAAAAEAACcQAAAAEJsGQETmIVOQp1awwpQnH/TEcUfX6CxtH4LfQAbs0dep4A7T69fATmh8F9K3AWb3Ug==", "995fe18e-b1d2-4961-b67e-ba5d9efc34c0" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 16, 10, 57, 30, 776, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 16, 10, 57, 30, 776, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 16, 10, 57, 30, 776, DateTimeKind.Local).AddTicks(8924));
        }
    }
}
