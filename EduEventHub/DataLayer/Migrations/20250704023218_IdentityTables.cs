using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class IdentityTables : Migration
    {
        /// <inheritdoc />
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 369, DateTimeKind.Utc).AddTicks(4974), new DateTime(2025, 7, 4, 2, 32, 16, 369, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 369, DateTimeKind.Utc).AddTicks(5759), new DateTime(2025, 7, 4, 2, 32, 16, 369, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 369, DateTimeKind.Utc).AddTicks(5760), new DateTime(2025, 7, 4, 2, 32, 16, 369, DateTimeKind.Utc).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 369, DateTimeKind.Utc).AddTicks(5761), new DateTime(2025, 7, 4, 2, 32, 16, 369, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 369, DateTimeKind.Utc).AddTicks(5763), new DateTime(2025, 7, 4, 2, 32, 16, 369, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(7819), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8282), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8286), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8287), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8289), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8291), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8292), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8851), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9678), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9682), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9683), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9684), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9686), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9785), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9787), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9789), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9790), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9791), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(5325), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(6981), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(6986), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(6989), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(7015), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 371, DateTimeKind.Utc).AddTicks(660), new DateTime(2025, 7, 4, 2, 32, 16, 371, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 371, DateTimeKind.Utc).AddTicks(1371), new DateTime(2025, 7, 4, 2, 32, 16, 371, DateTimeKind.Utc).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 371, DateTimeKind.Utc).AddTicks(1374), new DateTime(2025, 7, 4, 2, 32, 16, 371, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 371, DateTimeKind.Utc).AddTicks(1376), new DateTime(2025, 7, 4, 2, 32, 16, 371, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 371, DateTimeKind.Utc).AddTicks(1378), new DateTime(2025, 7, 4, 2, 32, 16, 371, DateTimeKind.Utc).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 371, DateTimeKind.Utc).AddTicks(1380), new DateTime(2025, 7, 4, 2, 32, 16, 371, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(2839), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(3801), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(3805), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(3807), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(3808), new DateTime(2025, 7, 4, 2, 32, 16, 370, DateTimeKind.Utc).AddTicks(3809) });

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
        }

        /// <inheritdoc />
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 975, DateTimeKind.Utc).AddTicks(7209), new DateTime(2025, 6, 21, 16, 48, 10, 975, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 975, DateTimeKind.Utc).AddTicks(7961), new DateTime(2025, 6, 21, 16, 48, 10, 975, DateTimeKind.Utc).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 975, DateTimeKind.Utc).AddTicks(7964), new DateTime(2025, 6, 21, 16, 48, 10, 975, DateTimeKind.Utc).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 975, DateTimeKind.Utc).AddTicks(8018), new DateTime(2025, 6, 21, 16, 48, 10, 975, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 975, DateTimeKind.Utc).AddTicks(8019), new DateTime(2025, 6, 21, 16, 48, 10, 975, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3297), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3881), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3885), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3889), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3892), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3895), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3898), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(4522), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5399), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5402), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5404), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5405), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5407), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5408), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5409), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5411), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5413), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5414), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(280), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(2272), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(2277), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(2280), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(2282), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(6052), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(6693), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(6696), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(6760), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(6763), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(6765), new DateTime(2025, 6, 21, 16, 48, 10, 977, DateTimeKind.Utc).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 976, DateTimeKind.Utc).AddTicks(4526), new DateTime(2025, 6, 21, 16, 48, 10, 976, DateTimeKind.Utc).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 976, DateTimeKind.Utc).AddTicks(6480), new DateTime(2025, 6, 21, 16, 48, 10, 976, DateTimeKind.Utc).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 976, DateTimeKind.Utc).AddTicks(6485), new DateTime(2025, 6, 21, 16, 48, 10, 976, DateTimeKind.Utc).AddTicks(6485) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 976, DateTimeKind.Utc).AddTicks(6487), new DateTime(2025, 6, 21, 16, 48, 10, 976, DateTimeKind.Utc).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 48, 10, 976, DateTimeKind.Utc).AddTicks(6488), new DateTime(2025, 6, 21, 16, 48, 10, 976, DateTimeKind.Utc).AddTicks(6488) });
        }
    }
}
