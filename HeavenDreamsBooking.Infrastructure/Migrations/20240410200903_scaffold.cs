using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class scaffold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a4b4694-c3d6-4085-8202-56758d2f2925",
                column: "ConcurrencyStamp",
                value: "92c4f2cf-ed48-4219-afdb-228769cb4a53");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bsmrol45-b34a-s67r-m123-b1s2m3r5o7l9",
                column: "ConcurrencyStamp",
                value: "f6b1eb5f-f1df-47d2-919e-8a45e1b574a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3pu12ro-em45-u1l3-r864-e3m2p1u8r6o2",
                column: "ConcurrencyStamp",
                value: "c86da694-93f2-4086-aecf-e430aa5ee4ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "usle1234-45er-o1l3-r8le-u4s2e1e876ro",
                column: "ConcurrencyStamp",
                value: "5fcdf746-2fa4-4c06-908f-57d477f4c445");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26e61ce3-7217-4355-9e68-043b4c6569e9", "AQAAAAEAACcQAAAAEKqjxo2ZeKTOwcOFFWFCd6OWT9OZm20bTdw3/WL1jc+RyeZC5EzJA3lJXECbKEZ2Kg==", "df7a74d9-28f5-4a76-9503-9d7f114e2282" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3532dd3-40f4-4c8c-9074-ecdfc9e01b9d", "AQAAAAEAACcQAAAAEIixAwE5NHfVpXzEyMMYNkn52OVztog+qqM1WoRiPX/B038ZAhxaxWIs8/DhPwMbMA==", "2212fc3e-6899-4ff1-bae9-5007296b2277" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d77dfbdc-70b1-45ad-9b66-1be0cd7b7064", "AQAAAAEAACcQAAAAEFQITIXCR75Tlube7CU9LqK2q2hJvesCKzjQ2yNKCloKhBR+Mw3HpPkvI29unUOj4A==", "3c4e3247-66f3-429a-8dae-16a7a338cb1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1234-45er-u123-r86s-u3s2e1e87614",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5038641-27e2-4368-a55b-e408f28b1937", "AQAAAAEAACcQAAAAEBieWYxfR1NrBxqvi5W9L/6MLqYwkuwdo1Lz/fAJQKVT8upDgGotRR1YQJg4jaLDug==", "e8d3c358-d530-47c6-9341-405b48afda73" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 10, 23, 9, 3, 68, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 10, 23, 9, 3, 68, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 10, 23, 9, 3, 68, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 10, 23, 9, 3, 68, DateTimeKind.Local).AddTicks(4740));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a4b4694-c3d6-4085-8202-56758d2f2925",
                column: "ConcurrencyStamp",
                value: "87aaba77-cec4-4adf-a8a0-e838e3ba2e10");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bsmrol45-b34a-s67r-m123-b1s2m3r5o7l9",
                column: "ConcurrencyStamp",
                value: "c3ca9a48-af86-49cb-825a-ab6e9b8387f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3pu12ro-em45-u1l3-r864-e3m2p1u8r6o2",
                column: "ConcurrencyStamp",
                value: "47eb6eaa-2585-45e8-a881-03514949dd3f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "usle1234-45er-o1l3-r8le-u4s2e1e876ro",
                column: "ConcurrencyStamp",
                value: "f199b648-e985-4582-9a42-d074be2d039d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad2ec01e-eac7-4b0b-a424-55185212348e", "AQAAAAEAACcQAAAAEK8vDknUSXl+6tLIq45rKUD58u/eBg1RpuJbh3ClAtcdedrMm9UNXBc88NzL3ENu+A==", "e3ceccb0-0e0c-4de4-8b45-eed86661c1ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "836065f4-332c-48ae-8eb5-1fa877253f70", "AQAAAAEAACcQAAAAEEQLJZlhnUZejF/vi0yqdZr1N1uj3PpWOrpCBIMN5UVfX5MDX12N3etOf2J54z3E4A==", "87e92706-c7fc-4abf-b8e5-c08bc4145d7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee412626-1178-468b-978a-c3ec96c3e6a6", "AQAAAAEAACcQAAAAEE3FyfsvQVkir5DHEzS/GOFCaDbjqJ3N7p9O3hv3eqZ2W0RR5WDtxyNjjfZF1ge8tw==", "89667a5a-d350-4a52-b9a9-ea41428e7b55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1234-45er-u123-r86s-u3s2e1e87614",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d33c62d1-4a8c-4de8-82ac-2ec42edb5709", "AQAAAAEAACcQAAAAEG13l1ryUGkIQJkx7Y7D4+bVP7wqASd1FQKVU8MfviRAIqUl3Q8I69FSIoq3HyZK8w==", "2c71aecf-6362-42cc-a019-be8915783692" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 9, 21, 50, 13, 259, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 9, 21, 50, 13, 259, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 9, 21, 50, 13, 259, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 9, 21, 50, 13, 259, DateTimeKind.Local).AddTicks(1694));
        }
    }
}
