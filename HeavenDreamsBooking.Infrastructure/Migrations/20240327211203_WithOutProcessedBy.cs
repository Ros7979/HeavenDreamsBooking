using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class WithOutProcessedBy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcessedBies");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ce3b846-454f-47d2-9d5a-315817660397");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69c8ebe5-9fae-4009-8fa5-4a78c4ab2b35", "ad102867-d405-48c7-80cc-e2d3560a1fc6", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cf2decc-04e3-4c59-9d8b-f7f834868e9d", "AQAAAAEAACcQAAAAEFztty7noF4w6bB85tMu7MawPGFm5pitnFGDj3rOvtRRvgDOmr93lQK9FuEHE4Npnw==", "50dc4d66-8f32-498d-bae7-7cc35c8b6817" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "314fcf5c-55f5-4d36-8bbb-c561f6168f3e", "AQAAAAEAACcQAAAAEF1qGQ2ObCYbFEgZxtYPcLLNhD38tWl4ZMbtMKyyYySkjadVsZtdt6wncHzOGH0cyw==", "9ded2444-1f35-4571-95d8-dfc77987b162" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "680d0129-a10d-4cf2-9339-5d32203aebbd", "AQAAAAEAACcQAAAAEC/38m2BssRvIc2tROcDwf0MK6egpqOJA6XVmjH4SKkYJQWL4Q7FglAMMb1rGM3eQA==", "eacdebf6-c00c-45b6-87eb-833c286105f8" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 27, 23, 12, 2, 595, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 27, 23, 12, 2, 595, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 27, 23, 12, 2, 595, DateTimeKind.Local).AddTicks(6098));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69c8ebe5-9fae-4009-8fa5-4a78c4ab2b35");

            migrationBuilder.CreateTable(
                name: "ProcessedBies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessedBies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessedBies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ce3b846-454f-47d2-9d5a-315817660397", "bee6a597-920b-4c65-aa3c-c93164d33373", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ee9066e-79ff-49a6-ae3c-3834135381df", "AQAAAAEAACcQAAAAEC8PFS7xsCUPANqoI5EeitNCxeJpQTwN6txmi9VVaVZk6PUSu2JP4uSApqMHFV22jQ==", "b133c257-3117-45ac-9830-a479e82a4336" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf4b7442-b74f-4149-94d8-3c67a2ce9b5c", "AQAAAAEAACcQAAAAELNNKEi4Av0RkyEH0SZT7KCEDBtimfIe7CaVJ/TtbNocLLiM58DSgy5DfZug+kBQSA==", "65ba8c89-aeee-448d-b83d-1c3e40417c15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "937f4267-f058-4269-a66e-95f6e7809712", "AQAAAAEAACcQAAAAEEf/prEPOHXvmQ2cgtnQrIE+ojJjT2avRlstcmn+FwgS/078ZvGrh6bHnbiAp43A+Q==", "665fa988-5c1b-48dc-9cd0-9fbff214ba9a" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 26, 21, 11, 13, 198, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 26, 21, 11, 13, 198, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 26, 21, 11, 13, 198, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.InsertData(
                table: "ProcessedBies",
                columns: new[] { "Id", "Email", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { 1, null, "+359878907060", "bsm12345-b345-s678-m123-b1s2m3456789" },
                    { 2, null, "+359778204906", "adm12345-a345-d678-m321-a3d2m1987654" },
                    { 3, null, "+359778204906", "empu1234-em45-u123-r864-e3m2p1u87652" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProcessedBies_UserId",
                table: "ProcessedBies",
                column: "UserId");
        }
    }
}
