using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a4b4694-c3d6-4085-8202-56758d2f2925",
                column: "ConcurrencyStamp",
                value: "2e6473c6-1a0a-4353-a664-8ebbf9a90eba");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bsmrol45-b34a-s67r-m123-b1s2m3r5o7l9", "3d8785ba-9452-447d-ba3a-e4b1245f42ee", "BusinessManager", "BUSINESSMANAGER" },
                    { "e3pu12ro-em45-u1l3-r864-e3m2p1u8r6o2", "67a4dfed-7ffc-4f4f-856e-0e1a9f83e25c", "Employee", "EMPLOYEE" },
                    { "usle1234-45er-o1l3-r8le-u4s2e1e876ro", "a6243959-58f7-41e0-bdcc-35f656be64b1", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d1bfb9e-ee38-4693-895c-96f8e6b0f9e4", "AQAAAAEAACcQAAAAEBzfTCcSMPAPlOFfsNIAOHAtz4R5IM1yPt+QvZhVOF70cvsQynmi8sMNoTtw7jwcSQ==", "84a8bd93-3589-4bfb-9466-6d54b66ac268" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcdf4b3c-4769-49e6-b43c-3559675963bd", "AQAAAAEAACcQAAAAEO7sHDzpqiUxHcVHXvmYxN9jisyvseESbq8xLey/noQ0SdZEEjJUpGNbJJu1f78HRg==", "70ef85a6-47e1-4208-b4c8-ee264bd632c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb731518-2e92-499e-bfbc-ea9ac073f03c", "AQAAAAEAACcQAAAAEKDGTuv/GphS1S2SDk9CiQQRl+CRmC9FzFKwwpp8B8IsPXcVu/uCZjrqYdAqx+uuhw==", "ac939af5-d5d0-4871-b33e-73be90b515c7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "user1234-45er-u123-r86s-u3s2e1e87614", 0, "01f231c1-1f43-4181-b073-20764f0d777e", "useruser@mail.bg", true, false, null, "useruser@mail.bg", "useruser@mail.bg", null, null, false, "404a1c57-acfa-45fa-9c0a-3c3994e1ade8", false, "useruser@mail.bg" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 4, 22, 48, 58, 867, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 4, 22, 48, 58, 867, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 4, 22, 48, 58, 867, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 4, 22, 48, 58, 867, DateTimeKind.Local).AddTicks(4936));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bsmrol45-b34a-s67r-m123-b1s2m3r5o7l9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3pu12ro-em45-u1l3-r864-e3m2p1u8r6o2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "usle1234-45er-o1l3-r8le-u4s2e1e876ro");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1234-45er-u123-r86s-u3s2e1e87614");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a4b4694-c3d6-4085-8202-56758d2f2925",
                column: "ConcurrencyStamp",
                value: "7662a2b8-83d2-478d-baaa-4753d3632038");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07316c39-84f2-4eed-b582-84ad5edee5a0", "AQAAAAEAACcQAAAAEKscI/zbUEoIiOvCveDxmslghC+vnHS90VKCrB+FLYXkKrzv9kmxv1FXaTgxrLrUew==", "9f63830e-7536-4683-980b-5a0f5c13592c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcccb97b-eb69-4989-847d-5a8592e9ae69", "AQAAAAEAACcQAAAAELJXXaYT4FsFhPo7QYvrFuoxZaIG8WrsKfxUeu8vIr1kz09W2Dd6M7G8kVqsrGkc8g==", "73ba1ecc-3e1c-4430-902c-260f970ec985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a13d797-561e-4e5f-9d8a-9b0e164ae36e", "AQAAAAEAACcQAAAAEPYEU33pOwD6FVbUaV25XQOdZbD4eZxJ0BasKzbEp7NgCxXORbeKejMCYPT2GqeqKw==", "01df978a-a82f-4fd9-916d-7114f214278f" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 1, 22, 34, 51, 360, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 1, 22, 34, 51, 360, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 1, 22, 34, 51, 360, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 1, 22, 34, 51, 360, DateTimeKind.Local).AddTicks(156));
        }
    }
}
