using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class datachange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a4b4694-c3d6-4085-8202-56758d2f2925",
                column: "ConcurrencyStamp",
                value: "0473f5e4-167f-4f30-9d77-215b0ade792a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bsmrol45-b34a-s67r-m123-b1s2m3r5o7l9",
                column: "ConcurrencyStamp",
                value: "f85b3e80-5509-4ebd-a91a-8d1d9b4d9459");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3pu12ro-em45-u1l3-r864-e3m2p1u8r6o2",
                column: "ConcurrencyStamp",
                value: "6f53abae-076f-4dff-b827-840c12afda75");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "usle1234-45er-o1l3-r8le-u4s2e1e876ro",
                column: "ConcurrencyStamp",
                value: "3a24a9b1-835c-4e3c-8f65-00f3a219dfed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2f7157f-68bb-488e-a4e5-27617643345f", "AQAAAAEAACcQAAAAEBAoaNsLuFNl2rBES9G8qO7V8kLKZCB9fb1NBWLuEXFw148FkeUber6EG4BPBZiNdA==", "83d4c6fe-839a-493a-96a1-7751496f8acb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cf0cc5a-d921-4588-96e9-31257ad04d20", "AQAAAAEAACcQAAAAEMrip0ShbXE+2NFq+0amsIOsVq6LxmwqfMp0sJwZLRKekgyiNDDW2d69HeOZMB2diQ==", "265b4c04-e6d4-410d-8eba-bc6ee8cfc3ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64f36f17-6c49-43a4-8061-ae53a3ebe6a5", "AQAAAAEAACcQAAAAEN+qZ+F5c1feMHesH5Q1c+7o4cQy8jy7k5Hx1ADL0Fxt8UE+KUSl+a+smHsZNH+5ig==", "b1668753-bf8f-43dd-b2b1-99958b703f4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1234-45er-u123-r86s-u3s2e1e87614",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7ebf719-3f54-4adf-a8fc-06e8c82e6a6f", "AQAAAAEAACcQAAAAEPhqWRhIKvGNp2JplNuKneWC9/Rmmkm6ywlTGvKjZ2ToTv7fSHquxBQbNtvbIJvxMQ==", "7bb4b8f6-9f82-47d1-a64f-cd26bb75a0c4" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 13, 17, 57, 29, 654, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 13, 17, 57, 29, 654, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 13, 17, 57, 29, 654, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "LaunchDate",
                value: new DateTime(2024, 4, 13, 17, 57, 29, 654, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "FlightStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfJorney",
                value: new DateTime(2024, 10, 11, 8, 30, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "FlightStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfJorney",
                value: new DateTime(2024, 10, 10, 6, 30, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
