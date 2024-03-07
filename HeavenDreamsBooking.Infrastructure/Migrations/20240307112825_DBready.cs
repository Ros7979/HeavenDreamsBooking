using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class DBready : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce12078c-06fa-461a-969f-7ccd2565d41d", "AQAAAAEAACcQAAAAEB41VRjGBHABjkBohOfkZlwgHpCse+7hKI8reG0V4p99jhk32p9vkmzVqt+zWpReOw==", "d0054d59-0afd-4ba7-a27e-9d008aedf303" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e0125a9-a14f-4b50-9b27-d9ef72718fe5", "AQAAAAEAACcQAAAAEP6Q2cpZZtsTLG+kIzAMZaOdBg4iLHaBMV3mcGkgwxbT53SHlH7NG2R+QvJQgyzHug==", "fdb45a27-d8e5-4d2e-a7fe-f9d8b11202cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e7135cb-1110-4ee7-b13f-b8c2aaf86afe", "AQAAAAEAACcQAAAAEMvwms9KDA+1RJaIDxdJlHlUKcYjZUeLq0eJDgkOASMtZin6KeCMV9ogLiWj/am7wQ==", "1f2c45bb-1ee9-444b-9aac-4a423c23335b" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 7, 13, 28, 25, 361, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 7, 13, 28, 25, 361, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 7, 13, 28, 25, 361, DateTimeKind.Local).AddTicks(5178));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4002b4f-c588-466d-bb17-5fdd49addc7a", "AQAAAAEAACcQAAAAEN3m0lYjxjY0cO6Ccyhuerf52gbDTSTCk0kBtz/OPt53942g0nvB1FAELx102+cq1w==", "f9dd5e26-35c2-48a2-936a-874452a93bab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0fe313c-5351-40c8-a60e-2b1dcf65b14f", "AQAAAAEAACcQAAAAEMDH4ZPFhDGqDHOqx9nGX/NSlqDHfuJhnNb+uZUxpUa/BQCSJ/0tOA5/JTw50vck5g==", "3916eea8-bd69-4fd9-a93d-27c8b6c90ed1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43a6cda6-d803-47c4-ab0c-7484cf5bb719", "AQAAAAEAACcQAAAAECZt+bjeuWYQj0NhUeqlCqNADxkJIa2g+yWHiRosmQdtNN3RdBvEqrn0yZjnwYdsEw==", "9ffe9ced-f3cc-4be8-bb63-93a9f281c3b9" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 7, 12, 32, 51, 80, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 7, 12, 32, 51, 80, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 7, 12, 32, 51, 80, DateTimeKind.Local).AddTicks(6392));
        }
    }
}
