using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class UserRoles1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a4b4694-c3d6-4085-8202-56758d2f2925",
                column: "ConcurrencyStamp",
                value: "218a2978-4c77-4792-ac68-93572f0612e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bsmrol45-b34a-s67r-m123-b1s2m3r5o7l9",
                column: "ConcurrencyStamp",
                value: "ee859a49-5414-4254-b85e-4c764a1747dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3pu12ro-em45-u1l3-r864-e3m2p1u8r6o2",
                column: "ConcurrencyStamp",
                value: "6beff526-e693-47c6-8939-ddad543205f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "usle1234-45er-o1l3-r8le-u4s2e1e876ro",
                column: "ConcurrencyStamp",
                value: "8098f6e5-733b-4039-a20f-7ce0eef7d71b");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1a4b4694-c3d6-4085-8202-56758d2f2925", "adm12345-a345-d678-m321-a3d2m1987654" },
                    { "bsmrol45-b34a-s67r-m123-b1s2m3r5o7l9", "bsm12345-b345-s678-m123-b1s2m3456789" },
                    { "e3pu12ro-em45-u1l3-r864-e3m2p1u8r6o2", "empu1234-em45-u123-r864-e3m2p1u87652" },
                    { "usle1234-45er-o1l3-r8le-u4s2e1e876ro", "user1234-45er-u123-r86s-u3s2e1e87614" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed10ce76-0e9a-4c58-9a21-2678ffeaea1f", "AQAAAAEAACcQAAAAEAUJDz/cx0fYy3z3aJ9GjuNUyAC+5bZZ5yQhCiRrNNgWU4hP3aXM/GfsdIAOdSADqA==", "ea7f5c71-6cda-45ef-9fbd-275341fc52dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8bea476-9fbb-4e67-bea1-e35ab512f514", "AQAAAAEAACcQAAAAED8vFOXG8U/T1DfqVGsGxQtX/1K97S9hpTvGKB1AdaWu0COmqEb/CLq5Scm/n+L6SA==", "46707ba3-e28c-4893-a3cd-3e58672b5c9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "995803d0-86eb-4cda-98eb-4d482d68fc0b", "AQAAAAEAACcQAAAAEOm8QhXJN3bGu3QFnj0moAI2qzfxT7kZBe44nglTJCkf7QmKhEbf7tZA4aQpc3SzGQ==", "a810e11d-ff4f-408e-9685-b1c8674af0e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1234-45er-u123-r86s-u3s2e1e87614",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c488d77-8a5e-4275-bb05-9f8143317785", "AQAAAAEAACcQAAAAEIq46+aMXXVTdtHVyXUuhPM9XG6C/+hUP4y+INmTOkf/+AWAbKpK/UmsHVj8Bhddwg==", "a5b1ae75-699f-40f6-b2bd-926c2e411615" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 4, 23, 3, 13, 741, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 4, 23, 3, 13, 741, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 4, 23, 3, 13, 741, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 4, 23, 3, 13, 741, DateTimeKind.Local).AddTicks(8823));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a4b4694-c3d6-4085-8202-56758d2f2925", "adm12345-a345-d678-m321-a3d2m1987654" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bsmrol45-b34a-s67r-m123-b1s2m3r5o7l9", "bsm12345-b345-s678-m123-b1s2m3456789" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e3pu12ro-em45-u1l3-r864-e3m2p1u8r6o2", "empu1234-em45-u123-r864-e3m2p1u87652" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "usle1234-45er-o1l3-r8le-u4s2e1e876ro", "user1234-45er-u123-r86s-u3s2e1e87614" });

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
    }
}
