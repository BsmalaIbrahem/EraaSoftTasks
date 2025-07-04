using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class SeedSuperAdminData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "SuperAdmin", "SUPERADMIN" },
                    { "b51709cf-231e-485a-86e1-dc5ecd3d3dad", null, "User", "USER" },
                    { "f03b9e1d-c4d0-425e-99c5-ea54e1c42efd", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "ad0d75ef-6183-4d57-a97f-c6ade9645b32", "super@gmail.com", true, "Super", "Admin", false, null, null, null, "AQAAAAIAAYagAAAAEHN5157xjZDDrUPYzXXPuL7vISRqfh34Q7P12n86VESD+4a4pqdeATM3fQmFuyL5FA==", null, false, "3cdcb6c6-6f85-4a38-9814-f52ba485c099", false, "SuperAdmin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 46, DateTimeKind.Utc).AddTicks(4820), new DateTime(2025, 7, 4, 2, 44, 38, 46, DateTimeKind.Utc).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 46, DateTimeKind.Utc).AddTicks(5761), new DateTime(2025, 7, 4, 2, 44, 38, 46, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 46, DateTimeKind.Utc).AddTicks(5764), new DateTime(2025, 7, 4, 2, 44, 38, 46, DateTimeKind.Utc).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 46, DateTimeKind.Utc).AddTicks(5766), new DateTime(2025, 7, 4, 2, 44, 38, 46, DateTimeKind.Utc).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 46, DateTimeKind.Utc).AddTicks(5767), new DateTime(2025, 7, 4, 2, 44, 38, 46, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(8553), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9071), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9075), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9077), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9079), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9082), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9084), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9813), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(809), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(812), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(814), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(815), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(817), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(818), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(819), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(821), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(822), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(824), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(5492), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(7472), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(7478), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(7501), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(7504), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(1691), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(2406), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(2409), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(2412), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(2414), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(2416), new DateTime(2025, 7, 4, 2, 44, 38, 48, DateTimeKind.Utc).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(2673), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(3744), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(3747), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(3749), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(3751), new DateTime(2025, 7, 4, 2, 44, 38, 47, DateTimeKind.Utc).AddTicks(3751) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b51709cf-231e-485a-86e1-dc5ecd3d3dad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f03b9e1d-c4d0-425e-99c5-ea54e1c42efd");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

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
        }
    }
}
