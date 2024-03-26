using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class flightStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightsCanseled_ProcessedBies_ProcessedById",
                table: "FlightsCanseled");

            migrationBuilder.DropIndex(
                name: "IX_FlightsCanseled_ProcessedById",
                table: "FlightsCanseled");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0d99640-21a3-4ce3-923e-032fc707724b");

            migrationBuilder.DropColumn(
                name: "ProcessedById",
                table: "FlightsCanseled");

            migrationBuilder.RenameColumn(
                name: "TicketNo",
                table: "FlightsCanseled",
                newName: "FltNo");

            migrationBuilder.AlterColumn<float>(
                name: "Refund",
                table: "FlightsCanseled",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfJorney",
                table: "FlightsCanseled",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "FlightsCanseled",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "FlightsCanseled",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "FlightsCanseled",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "FareEconomy",
                table: "FlightDetails",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FareBusines",
                table: "FlightDetails",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.CreateTable(
                name: "FlightStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FltNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FlightDetailsId = table.Column<int>(type: "int", nullable: false),
                    DateOfJorney = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusEconomy = table.Column<int>(type: "int", nullable: false),
                    WaitListedEconomy = table.Column<int>(type: "int", nullable: false),
                    StatusBusiness = table.Column<int>(type: "int", nullable: false),
                    WaitListedBusiness = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlightStatus_FlightDetails_FlightDetailsId",
                        column: x => x.FlightDetailsId,
                        principalTable: "FlightDetails",
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

            migrationBuilder.CreateIndex(
                name: "IX_FlightsCanseled_UserId",
                table: "FlightsCanseled",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightStatus_FlightDetailsId",
                table: "FlightStatus",
                column: "FlightDetailsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightsCanseled_AspNetUsers_UserId",
                table: "FlightsCanseled",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightsCanseled_AspNetUsers_UserId",
                table: "FlightsCanseled");

            migrationBuilder.DropTable(
                name: "FlightStatus");

            migrationBuilder.DropIndex(
                name: "IX_FlightsCanseled_UserId",
                table: "FlightsCanseled");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ce3b846-454f-47d2-9d5a-315817660397");

            migrationBuilder.DropColumn(
                name: "DateOfJorney",
                table: "FlightsCanseled");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "FlightsCanseled");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "FlightsCanseled");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FlightsCanseled");

            migrationBuilder.RenameColumn(
                name: "FltNo",
                table: "FlightsCanseled",
                newName: "TicketNo");

            migrationBuilder.AlterColumn<int>(
                name: "Refund",
                table: "FlightsCanseled",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "ProcessedById",
                table: "FlightsCanseled",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "FareEconomy",
                table: "FlightDetails",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FareBusines",
                table: "FlightDetails",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0d99640-21a3-4ce3-923e-032fc707724b", "9947f9f1-7a0d-4526-9386-33d58e2e4201", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adm12345-a345-d678-m321-a3d2m1987654",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2250f58c-0ea9-4289-8d37-3d4066af3baa", "AQAAAAEAACcQAAAAEGHTwJKPyX/Uie4zEfKRsVcYs0hGFKn7FuplrCXO3QASUZUcuHIt+bgZ6KQoK8vZ4Q==", "faaca918-46a4-4e03-99e8-359e090b8c07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bsm12345-b345-s678-m123-b1s2m3456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e41ca55-4fbd-4a8a-b00d-46e5373521ff", "AQAAAAEAACcQAAAAEP32dnhtorjBnygmxR4Q50cMObjh8i8K88gi+05GpE6OKgziggwPtOhGnF3oEpFmAw==", "35fda86f-d613-4618-ad75-4ef96b91a569" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "empu1234-em45-u123-r864-e3m2p1u87652",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e084309-be08-4837-9e2f-294ab753df65", "AQAAAAEAACcQAAAAEBFczrSPJ65diOGWJfg16wNHbbudEVu97j8T4voVZ+XBAg5mMQ5arQ2D4Vh5DLXVhg==", "672fea06-bcdf-4162-86b9-1efbec168d9c" });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 25, 8, 18, 15, 365, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 25, 8, 18, 15, 365, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "LaunchDate",
                value: new DateTime(2024, 3, 25, 8, 18, 15, 365, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.CreateIndex(
                name: "IX_FlightsCanseled_ProcessedById",
                table: "FlightsCanseled",
                column: "ProcessedById");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightsCanseled_ProcessedBies_ProcessedById",
                table: "FlightsCanseled",
                column: "ProcessedById",
                principalTable: "ProcessedBies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
