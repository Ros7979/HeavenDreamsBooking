using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class UserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a4b4694-c3d6-4085-8202-56758d2f2925",
                column: "ConcurrencyStamp",
                value: "1f00707f-6131-4d09-b9ba-89f188eaafcc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bsmrol45-b34a-s67r-m123-b1s2m3r5o7l9",
                column: "ConcurrencyStamp",
                value: "b3e2a8cf-79fc-4594-af79-e6a9796212b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3pu12ro-em45-u1l3-r864-e3m2p1u8r6o2",
                column: "ConcurrencyStamp",
                value: "92067b20-d071-4000-b93b-957410149f7e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "usle1234-45er-o1l3-r8le-u4s2e1e876ro",
                column: "ConcurrencyStamp",
                value: "55bcb72d-12d6-4cd6-a370-8901190dec00");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59d67030-2b1e-475a-a9c3-7264706c1407", "AQAAAAEAACcQAAAAEDRh/IT0yGBy01v3QB6ApoltSqdTR6Qo0WYeqMRvsEHMBomhjcIjzoOvVoJ53vu7vw==", "8b37d6e9-59d1-403c-a71a-813a6e3d393f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be0b0224-d053-47f8-81b5-76d646fbb6a5", "AQAAAAEAACcQAAAAEGx4ZJfzNOkqsgr/iiK668f0fyRPuAXTjgghrf2yKpjxz8Jvw2Js0Jxiz5SI3XQtMA==", "ecdc3e52-bf3f-4849-a1af-ce623e7df424" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62ba764f-e9a4-447f-a838-c4c85245069c", "AQAAAAEAACcQAAAAEOQyk7F0sHgbjQRyW/LnAzO+ywGyF24W0KOrlGljMiFqJEcywL4VaT8Tap6iVoHtkA==", "5bbb2140-33d6-4d81-a3f7-9f0d244a792f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1234-45er-u123-r86s-u3s2e1e87614",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd8b6f5d-b04a-4946-9454-e51076765780", "AQAAAAEAACcQAAAAED7LV3IysYgDNkhpl1SCtQd07axZLrWFGyJn7yxXcmhkIR8TDBDjjUDpJrINF1YQEg==", "9afff8a3-2eb0-4587-b812-cfbe061fe628" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 4, 23, 2, 0, 211, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 4, 23, 2, 0, 211, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 4, 23, 2, 0, 211, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 4, 23, 2, 0, 211, DateTimeKind.Local).AddTicks(5461));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a4b4694-c3d6-4085-8202-56758d2f2925",
                column: "ConcurrencyStamp",
                value: "2e6473c6-1a0a-4353-a664-8ebbf9a90eba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bsmrol45-b34a-s67r-m123-b1s2m3r5o7l9",
                column: "ConcurrencyStamp",
                value: "3d8785ba-9452-447d-ba3a-e4b1245f42ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3pu12ro-em45-u1l3-r864-e3m2p1u8r6o2",
                column: "ConcurrencyStamp",
                value: "67a4dfed-7ffc-4f4f-856e-0e1a9f83e25c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "usle1234-45er-o1l3-r8le-u4s2e1e876ro",
                column: "ConcurrencyStamp",
                value: "a6243959-58f7-41e0-bdcc-35f656be64b1");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1234-45er-u123-r86s-u3s2e1e87614",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01f231c1-1f43-4181-b073-20764f0d777e", null, "404a1c57-acfa-45fa-9c0a-3c3994e1ade8" });

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
    }
}
