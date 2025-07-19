using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class WishlistModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54b49ba7-b79b-4c0d-a01c-154967ad67db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8856e5f5-16b1-4e7a-863e-471bbff84697");

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => new { x.UserId, x.EventId });
                    table.ForeignKey(
                        name: "FK_Wishlists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wishlists_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3edcc6f2-c30c-471a-80fb-6a9786ae3470", null, "User", "USER" },
                    { "ad31d12d-e3ac-45c7-94e6-a9bb48aaf789", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09ddfbd1-ceb0-4e76-866a-a2dc0bd7eaa2", "AQAAAAIAAYagAAAAEHJs+pm20TRbQxAForJ3tGLujeaPE6jeTxN+fr3AgQCBqe08QLHdtc7ZLKWGwsxi2Q==", "c7e872b1-f6a0-47b9-b97b-bafb9c797266" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 417, DateTimeKind.Utc).AddTicks(8631), new DateTime(2025, 7, 19, 10, 33, 11, 417, DateTimeKind.Utc).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 418, DateTimeKind.Utc).AddTicks(669), new DateTime(2025, 7, 19, 10, 33, 11, 418, DateTimeKind.Utc).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 418, DateTimeKind.Utc).AddTicks(676), new DateTime(2025, 7, 19, 10, 33, 11, 418, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 418, DateTimeKind.Utc).AddTicks(679), new DateTime(2025, 7, 19, 10, 33, 11, 418, DateTimeKind.Utc).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 418, DateTimeKind.Utc).AddTicks(682), new DateTime(2025, 7, 19, 10, 33, 11, 418, DateTimeKind.Utc).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(918), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(2668), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(2678), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(2683), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(2688), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(2692), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(2697), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(4206), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7012), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7020), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7024), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7028), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7031), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7035), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7038), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7042), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7045), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7049), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 420, DateTimeKind.Utc).AddTicks(3755), new DateTime(2025, 7, 19, 10, 33, 11, 420, DateTimeKind.Utc).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 420, DateTimeKind.Utc).AddTicks(8812), new DateTime(2025, 7, 19, 10, 33, 11, 420, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 420, DateTimeKind.Utc).AddTicks(8826), new DateTime(2025, 7, 19, 10, 33, 11, 420, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 420, DateTimeKind.Utc).AddTicks(8833), new DateTime(2025, 7, 19, 10, 33, 11, 420, DateTimeKind.Utc).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 420, DateTimeKind.Utc).AddTicks(8840), new DateTime(2025, 7, 19, 10, 33, 11, 420, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(8731), new DateTime(2025, 7, 19, 10, 33, 11, 421, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 422, DateTimeKind.Utc).AddTicks(905), new DateTime(2025, 7, 19, 10, 33, 11, 422, DateTimeKind.Utc).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 422, DateTimeKind.Utc).AddTicks(912), new DateTime(2025, 7, 19, 10, 33, 11, 422, DateTimeKind.Utc).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 422, DateTimeKind.Utc).AddTicks(917), new DateTime(2025, 7, 19, 10, 33, 11, 422, DateTimeKind.Utc).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 422, DateTimeKind.Utc).AddTicks(922), new DateTime(2025, 7, 19, 10, 33, 11, 422, DateTimeKind.Utc).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 422, DateTimeKind.Utc).AddTicks(1061), new DateTime(2025, 7, 19, 10, 33, 11, 422, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 419, DateTimeKind.Utc).AddTicks(6292), new DateTime(2025, 7, 19, 10, 33, 11, 419, DateTimeKind.Utc).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 419, DateTimeKind.Utc).AddTicks(9462), new DateTime(2025, 7, 19, 10, 33, 11, 419, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 419, DateTimeKind.Utc).AddTicks(9471), new DateTime(2025, 7, 19, 10, 33, 11, 419, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 419, DateTimeKind.Utc).AddTicks(9476), new DateTime(2025, 7, 19, 10, 33, 11, 419, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 19, 10, 33, 11, 419, DateTimeKind.Utc).AddTicks(9543), new DateTime(2025, 7, 19, 10, 33, 11, 419, DateTimeKind.Utc).AddTicks(9544) });

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_EventId",
                table: "Wishlists",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3edcc6f2-c30c-471a-80fb-6a9786ae3470");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad31d12d-e3ac-45c7-94e6-a9bb48aaf789");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc036481-d939-422c-9cce-7093dcbab6b5", "AQAAAAIAAYagAAAAEN07ANF0L/oMzFzbB66DBwmhwFP+Qx2vImaZ/WjnckCiTVMZ5m5CwTO2ljtkaS8r2Q==", "ade5ebcb-e8db-492a-adc7-7e3b8e53119d" });

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
    }
}
