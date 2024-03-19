using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class UserNameAsEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "029cef0e-c4c6-4ade-ae94-fc0627690d97");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1501c14-18dd-4859-8484-bd7d294b2876", "4c96512a-14c5-4fb1-a38a-6656a2e6dbbe", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ba1f4473-1595-4aa7-a3b7-8fc01b19f924", "pvadminuser@mail.bg", "pvadminuser@mail.bg", "AQAAAAEAACcQAAAAEFJpYkmSG0YDupne77jk8EgUdZpKddZMoN2MHwwJGRVQnYE1i2xXSzja+3wseOxtlQ==", "410b751e-3800-4497-af38-35835ae3fc4f", "pvadminuser@mail.bg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0b7dedc8-2f33-4c95-9a5d-1ab38d3c2146", "isbusinessmanager@mail.bg", "AQAAAAEAACcQAAAAEG66VgReoiy/VIEY+PTsTpdw4hfgTiu3TktyHY5gh4UvGNd3x1xVfrUf33yOIKfQXQ==", "b2155ca0-eb43-4899-a994-9d54ae3f567e", "isbusinessmanager@mail.bg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "301fbfca-3fb4-44ca-9bb3-cca685942998", "spemployuser@mail.bg", "AQAAAAEAACcQAAAAEM71zmDRC8E9oZacq5odrd6qniHF1BZF6EN6w7ybmISHf8d1YWVdnpfBv7tANPTvug==", "3aaa492a-42df-417a-a903-d7b54a396db4", "spemployuser@mail.bg" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1501c14-18dd-4859-8484-bd7d294b2876");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "029cef0e-c4c6-4ade-ae94-fc0627690d97", "01992075-684e-4f88-ac76-b88b84ddf181", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "55735e24-cf29-4fe1-9c98-a84d0dbbfe76", "isadminuser@mail.bg", "Petar Vasilev", "AQAAAAEAACcQAAAAEBxrSaxCst+oTfuDDBFTMt040ULzX3lFrgkUGxaPgoAnsbLcYYXeuiGBCiaejyV+Pw==", "f9d09c62-e8c0-476a-b6a6-7d7ea451906d", "Petar Vasilev" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "51d0dc3f-e595-47ea-8d51-bfbec667efc5", "Ivan Stamenov", "AQAAAAEAACcQAAAAELM5fOT2vwW448keN4/rmKVjSeSwcJ6itHWoOeUzZv93LxXKVPM83ebgZwf7rcJpMw==", "3908d861-a6cd-4c7e-8244-e442622cab57", "Ivan Stamenov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "28c8a781-3c8d-4ad5-abab-e8da0b8490e0", "Svetla Peteva", "AQAAAAEAACcQAAAAEBWvrqJui5mTXe7RngeJ7SiKhsfqw4I3w7eZDqeyrJGjXi8MfeoPxBEZhjUgokXUug==", "9e171b94-b6ab-4b3e-a425-31944b0775c2", "Svetla Peteva" });

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
    }
}
