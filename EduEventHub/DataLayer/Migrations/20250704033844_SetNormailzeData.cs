using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class SetNormailzeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b51709cf-231e-485a-86e1-dc5ecd3d3dad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f03b9e1d-c4d0-425e-99c5-ea54e1c42efd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "54b49ba7-b79b-4c0d-a01c-154967ad67db", null, "Admin", "ADMIN" },
                    { "8856e5f5-16b1-4e7a-863e-471bbff84697", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc036481-d939-422c-9cce-7093dcbab6b5", "super@gmail.com", "SUPERADMIN", "AQAAAAIAAYagAAAAEN07ANF0L/oMzFzbB66DBwmhwFP+Qx2vImaZ/WjnckCiTVMZ5m5CwTO2ljtkaS8r2Q==", "ade5ebcb-e8db-492a-adc7-7e3b8e53119d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 389, DateTimeKind.Utc).AddTicks(5937), new DateTime(2025, 7, 4, 3, 38, 42, 389, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 389, DateTimeKind.Utc).AddTicks(6708), new DateTime(2025, 7, 4, 3, 38, 42, 389, DateTimeKind.Utc).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 389, DateTimeKind.Utc).AddTicks(6711), new DateTime(2025, 7, 4, 3, 38, 42, 389, DateTimeKind.Utc).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 389, DateTimeKind.Utc).AddTicks(6792), new DateTime(2025, 7, 4, 3, 38, 42, 389, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 389, DateTimeKind.Utc).AddTicks(6794), new DateTime(2025, 7, 4, 3, 38, 42, 389, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(8689), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9157), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9160), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9162), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9187), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9189), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9191), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9775), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(741), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(745), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(747), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(748), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(750), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(751), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(752), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(754), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(755), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(756), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(6227), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(7815), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(7821), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(7824), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(7827), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(1470), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(2144), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(2147), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(2149), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(2151), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(2153), new DateTime(2025, 7, 4, 3, 38, 42, 391, DateTimeKind.Utc).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(3646), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(4599), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(4602), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(4604), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(4606), new DateTime(2025, 7, 4, 3, 38, 42, 390, DateTimeKind.Utc).AddTicks(4606) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54b49ba7-b79b-4c0d-a01c-154967ad67db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8856e5f5-16b1-4e7a-863e-471bbff84697");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b51709cf-231e-485a-86e1-dc5ecd3d3dad", null, "User", "USER" },
                    { "f03b9e1d-c4d0-425e-99c5-ea54e1c42efd", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad0d75ef-6183-4d57-a97f-c6ade9645b32", null, null, "AQAAAAIAAYagAAAAEHN5157xjZDDrUPYzXXPuL7vISRqfh34Q7P12n86VESD+4a4pqdeATM3fQmFuyL5FA==", "3cdcb6c6-6f85-4a38-9814-f52ba485c099" });

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
        }
    }
}
