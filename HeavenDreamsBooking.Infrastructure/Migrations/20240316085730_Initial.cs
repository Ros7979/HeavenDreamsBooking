using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenDreamsBooking.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlightDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FltNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    From = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Flight image url"),
                    DepTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AircraftType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SeatsBusines = table.Column<int>(type: "int", nullable: false),
                    SeatsEconomy = table.Column<int>(type: "int", nullable: false),
                    FareBusines = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    FareEconomy = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    LaunchDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassengerDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    FareCollected = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    TotalTimesFlown = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcessedBies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "DeparturedFlights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateOfJorney = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassOfRes = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Fare = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ReservedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfRes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicketConfirmed = table.Column<bool>(type: "bit", nullable: true),
                    PassengerDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeparturedFlights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeparturedFlights_PassengerDetails_PassengerDetailId",
                        column: x => x.PassengerDetailId,
                        principalTable: "PassengerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegularFliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    PassengerDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegularFliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegularFliers_PassengerDetails_PassengerDetailId",
                        column: x => x.PassengerDetailId,
                        principalTable: "PassengerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightsCanseled",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Refund = table.Column<int>(type: "int", nullable: false),
                    ProcessedById = table.Column<int>(type: "int", nullable: false),
                    CanselationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightsCanseled", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlightsCanseled_ProcessedBies_ProcessedById",
                        column: x => x.ProcessedById,
                        principalTable: "ProcessedBies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FlightDetailsId = table.Column<int>(type: "int", nullable: false),
                    DateOfJorney = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassOfRes = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Fare = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ProcessedById = table.Column<int>(type: "int", nullable: false),
                    DateOfRes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicketConfirmed = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_FlightDetails_FlightDetailsId",
                        column: x => x.FlightDetailsId,
                        principalTable: "FlightDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_ProcessedBies_FlightDetailsId",
                        column: x => x.FlightDetailsId,
                        principalTable: "ProcessedBies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "adm12345-a345-d678-m321-a3d2m1987654", 0, "8dd06286-da6a-471f-b1ae-204524976360", "pvadminuser@mail.bg", false, false, null, "isadminuser@mail.bg", "Petar Vasilev", "AQAAAAEAACcQAAAAEHe8I6A8YDw2Ru51/8U3/o5V/ul3OG06MwrFZRhgyDZP0WNCIy2u1EW0KwjgMyrmAQ==", null, false, "8696c3a6-ff17-4b43-a498-64cdcab9f087", false, "Petar Vasilev" },
                    { "bsm12345-b345-s678-m123-b1s2m3456789", 0, "47c530c2-a0d9-42e1-ae3b-13951d38f1b1", "isbusinessmanager@mail.bg", false, false, null, "isbusinessmanager@mail.bg", "Ivan Stamenov", "AQAAAAEAACcQAAAAEDhX83ajy4IjqAjCTQLUxU4jDaSyMImY5viIAivxyCLfBXgiT7Lta+vZ1mHkVDILjQ==", null, false, "55ddcabc-45bc-410d-9b32-d04b47db3ae9", false, "Ivan Stamenov" },
                    { "empu1234-em45-u123-r864-e3m2p1u87652", 0, "e77b0a37-0c5e-4e8a-a4ea-0f939e11c09b", "spemployuser@mail.bg", false, false, null, "spemployuser@mail.bg", "Svetla Peteva", "AQAAAAEAACcQAAAAEJsGQETmIVOQp1awwpQnH/TEcUfX6CxtH4LfQAbs0dep4A7T69fATmh8F9K3AWb3Ug==", null, false, "995fe18e-b1d2-4961-b67e-ba5d9efc34c0", false, "Svetla Peteva" }
                });

            migrationBuilder.InsertData(
                table: "FlightDetails",
                columns: new[] { "Id", "AircraftType", "ArrTime", "DepTime", "Destination", "FareBusines", "FareEconomy", "FltNo", "From", "ImageUrl", "LaunchDate", "SeatsBusines", "SeatsEconomy" },
                values: new object[,]
                {
                    { 1, "Airbus a380", new DateTime(2024, 8, 24, 10, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 14, 35, 0, 0, DateTimeKind.Unspecified), "Барселона", 180.00m, 125.40m, "SOF-BCN", "София", "https://wallpaperaccess.com/full/1322174.jpg", new DateTime(2024, 3, 16, 10, 57, 30, 776, DateTimeKind.Local).AddTicks(8885), 30, 50 },
                    { 2, "Airbus a320", new DateTime(2024, 6, 14, 16, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 11, 30, 0, 0, DateTimeKind.Unspecified), "Ларнака", 280.00m, 200.00m, "SOF-LCA", "София", "https://www.goatsontheroad.com/wp-content/uploads/2022/11/Malindi-Beach-in-Limassol.jpeg", new DateTime(2024, 3, 16, 10, 57, 30, 776, DateTimeKind.Local).AddTicks(8921), 24, 40 },
                    { 3, "Boeing 747", new DateTime(2024, 10, 10, 23, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 6, 30, 0, 0, DateTimeKind.Unspecified), "Атина", 500.00m, 314.00m, "SOF-ATH", "София", "https://th.bing.com/th/id/OIP.gtnO8Z0v_QVMykrG4JUJygHaE8?rs=1&pid=ImgDetMain", new DateTime(2024, 3, 16, 10, 57, 30, 776, DateTimeKind.Local).AddTicks(8924), 4, 80 }
                });

            migrationBuilder.InsertData(
                table: "ProcessedBies",
                columns: new[] { "Id", "Email", "PhoneNumber", "UserId" },
                values: new object[] { 1, null, "+359878907060", "bsm12345-b345-s678-m123-b1s2m3456789" });

            migrationBuilder.InsertData(
                table: "ProcessedBies",
                columns: new[] { "Id", "Email", "PhoneNumber", "UserId" },
                values: new object[] { 2, null, "+359778204906", "adm12345-a345-d678-m321-a3d2m1987654" });

            migrationBuilder.InsertData(
                table: "ProcessedBies",
                columns: new[] { "Id", "Email", "PhoneNumber", "UserId" },
                values: new object[] { 3, null, "+359778204906", "empu1234-em45-u123-r864-e3m2p1u87652" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DeparturedFlights_PassengerDetailId",
                table: "DeparturedFlights",
                column: "PassengerDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightsCanseled_ProcessedById",
                table: "FlightsCanseled",
                column: "ProcessedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessedBies_UserId",
                table: "ProcessedBies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RegularFliers_PassengerDetailId",
                table: "RegularFliers",
                column: "PassengerDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_FlightDetailsId",
                table: "Reservations",
                column: "FlightDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeparturedFlights");

            migrationBuilder.DropTable(
                name: "FlightsCanseled");

            migrationBuilder.DropTable(
                name: "RegularFliers");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "PassengerDetails");

            migrationBuilder.DropTable(
                name: "FlightDetails");

            migrationBuilder.DropTable(
                name: "ProcessedBies");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
