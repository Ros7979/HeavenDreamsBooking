using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class scaffoldingDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
