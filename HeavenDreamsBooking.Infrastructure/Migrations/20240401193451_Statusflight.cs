using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class Statusflight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightStatus_FlightDetails_FlightDetailsId",
                table: "FlightStatus");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69c8ebe5-9fae-4009-8fa5-4a78c4ab2b35");

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "FlightDetailsId",
                table: "FlightStatus",
                newName: "FlightDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightStatus_FlightDetailsId",
                table: "FlightStatus",
                newName: "IX_FlightStatus_FlightDetailId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a4b4694-c3d6-4085-8202-56758d2f2925", "7662a2b8-83d2-478d-baaa-4753d3632038", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07316c39-84f2-4eed-b582-84ad5edee5a0", true, "AQAAAAEAACcQAAAAEKscI/zbUEoIiOvCveDxmslghC+vnHS90VKCrB+FLYXkKrzv9kmxv1FXaTgxrLrUew==", "9f63830e-7536-4683-980b-5a0f5c13592c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcccb97b-eb69-4989-847d-5a8592e9ae69", true, "AQAAAAEAACcQAAAAELJXXaYT4FsFhPo7QYvrFuoxZaIG8WrsKfxUeu8vIr1kz09W2Dd6M7G8kVqsrGkc8g==", "73ba1ecc-3e1c-4430-902c-260f970ec985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a13d797-561e-4e5f-9d8a-9b0e164ae36e", true, "AQAAAAEAACcQAAAAEPYEU33pOwD6FVbUaV25XQOdZbD4eZxJ0BasKzbEp7NgCxXORbeKejMCYPT2GqeqKw==", "01df978a-a82f-4fd9-916d-7114f214278f" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LaunchDate", "SeatsBusines", "SeatsEconomy" },
                values: new object[] { new DateTime(2024, 4, 1, 22, 34, 51, 360, DateTimeKind.Local).AddTicks(114), 3, 5 });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LaunchDate", "SeatsBusines", "SeatsEconomy" },
                values: new object[] { new DateTime(2024, 4, 1, 22, 34, 51, 360, DateTimeKind.Local).AddTicks(147), 4, 4 });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AircraftType", "ArrTime", "LaunchDate", "SeatsBusines", "SeatsEconomy" },
                values: new object[] { "Boeing 777", new DateTime(2024, 10, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 22, 34, 51, 360, DateTimeKind.Local).AddTicks(150), 8, 10 });

            migrationBuilder.InsertData(
                table: "FlightDetails",
                columns: new[] { "Id", "AircraftType", "ArrTime", "DepTime", "Destination", "FareBusines", "FareEconomy", "FltNo", "From", "ImageUrl", "LaunchDate", "SeatsBusines", "SeatsEconomy" },
                values: new object[] { 4, "Boeing 777", new DateTime(2024, 10, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 8, 30, 0, 0, DateTimeKind.Unspecified), "София", 500.00m, 314.00m, "ATH-SOF", "Атина", "https://th.bing.com/th/id/OIP.gtnO8Z0v_QVMykrG4JUJygHaE8?rs=1&pid=ImgDetMain", new DateTime(2024, 4, 1, 22, 34, 51, 360, DateTimeKind.Local).AddTicks(156), 8, 10 });

            migrationBuilder.InsertData(
                table: "FlightStatus",
                columns: new[] { "Id", "DateOfJorney", "FlightDetailId", "FltNo", "StatusBusiness", "StatusEconomy", "WaitListedBusiness", "WaitListedEconomy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 23, 14, 35, 0, 0, DateTimeKind.Unspecified), 1, "SOF-BCN", 5, 3, 0, 0 },
                    { 2, new DateTime(2024, 6, 14, 11, 30, 0, 0, DateTimeKind.Unspecified), 2, "SOF-LCA", 4, 4, 0, 0 },
                    { 3, new DateTime(2024, 10, 10, 6, 30, 0, 0, DateTimeKind.Unspecified), 3, "SOF-ATH", 10, 8, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "FlightStatus",
                columns: new[] { "Id", "DateOfJorney", "FlightDetailId", "FltNo", "StatusBusiness", "StatusEconomy", "WaitListedBusiness", "WaitListedEconomy" },
                values: new object[] { 4, new DateTime(2024, 10, 10, 6, 30, 0, 0, DateTimeKind.Unspecified), 4, "ATH-SOF", 10, 8, 0, 0 });

            migrationBuilder.AddForeignKey(
                name: "FK_FlightStatus_FlightDetails_FlightDetailId",
                table: "FlightStatus",
                column: "FlightDetailId",
                principalTable: "FlightDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightStatus_FlightDetails_FlightDetailId",
                table: "FlightStatus");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a4b4694-c3d6-4085-8202-56758d2f2925");

            migrationBuilder.DeleteData(
                table: "FlightStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FlightStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FlightStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FlightStatus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "FlightDetailId",
                table: "FlightStatus",
                newName: "FlightDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightStatus_FlightDetailId",
                table: "FlightStatus",
                newName: "IX_FlightStatus_FlightDetailsId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69c8ebe5-9fae-4009-8fa5-4a78c4ab2b35", "ad102867-d405-48c7-80cc-e2d3560a1fc6", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cf2decc-04e3-4c59-9d8b-f7f834868e9d", false, "AQAAAAEAACcQAAAAEFztty7noF4w6bB85tMu7MawPGFm5pitnFGDj3rOvtRRvgDOmr93lQK9FuEHE4Npnw==", "50dc4d66-8f32-498d-bae7-7cc35c8b6817" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "314fcf5c-55f5-4d36-8bbb-c561f6168f3e", false, "AQAAAAEAACcQAAAAEF1qGQ2ObCYbFEgZxtYPcLLNhD38tWl4ZMbtMKyyYySkjadVsZtdt6wncHzOGH0cyw==", "9ded2444-1f35-4571-95d8-dfc77987b162" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "680d0129-a10d-4cf2-9339-5d32203aebbd", false, "AQAAAAEAACcQAAAAEC/38m2BssRvIc2tROcDwf0MK6egpqOJA6XVmjH4SKkYJQWL4Q7FglAMMb1rGM3eQA==", "eacdebf6-c00c-45b6-87eb-833c286105f8" });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "DiscountGiven", "FareLimit", "TotalFlightsLimit" },
                values: new object[] { 2, 14.0, 7500.00m, 15 });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LaunchDate", "SeatsBusines", "SeatsEconomy" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 12, 2, 595, DateTimeKind.Local).AddTicks(6040), 30, 50 });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LaunchDate", "SeatsBusines", "SeatsEconomy" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 12, 2, 595, DateTimeKind.Local).AddTicks(6095), 24, 40 });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AircraftType", "ArrTime", "LaunchDate", "SeatsBusines", "SeatsEconomy" },
                values: new object[] { "Boeing 747", new DateTime(2024, 10, 10, 23, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 23, 12, 2, 595, DateTimeKind.Local).AddTicks(6098), 4, 80 });

            migrationBuilder.AddForeignKey(
                name: "FK_FlightStatus_FlightDetails_FlightDetailsId",
                table: "FlightStatus",
                column: "FlightDetailsId",
                principalTable: "FlightDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
