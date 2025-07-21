using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class CartModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3edcc6f2-c30c-471a-80fb-6a9786ae3470");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad31d12d-e3ac-45c7-94e6-a9bb48aaf789");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => new { x.UserId, x.EventId });
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Events_EventId",
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
                    { "98d27459-4250-4135-aabe-fe376a319581", null, "Admin", "ADMIN" },
                    { "d9081a0c-c993-4ff4-a7f5-7841d4220307", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4ecd34a-da0a-42e6-a548-9e990c6e0435", "AQAAAAIAAYagAAAAEAMqj4hWl7Xr3P+h4AuxNd06YUgUTiWYyZaMHPjyIRTinoeppZbtBLpwFxbTgzgyHw==", "78f7d23e-1caa-48b8-be86-c0f7d69f4967" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 529, DateTimeKind.Utc).AddTicks(5566), new DateTime(2025, 7, 21, 6, 43, 29, 529, DateTimeKind.Utc).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 529, DateTimeKind.Utc).AddTicks(6265), new DateTime(2025, 7, 21, 6, 43, 29, 529, DateTimeKind.Utc).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 529, DateTimeKind.Utc).AddTicks(6267), new DateTime(2025, 7, 21, 6, 43, 29, 529, DateTimeKind.Utc).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 529, DateTimeKind.Utc).AddTicks(6268), new DateTime(2025, 7, 21, 6, 43, 29, 529, DateTimeKind.Utc).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 529, DateTimeKind.Utc).AddTicks(6269), new DateTime(2025, 7, 21, 6, 43, 29, 529, DateTimeKind.Utc).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(7663), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8256), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8258), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8260), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8261), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8326), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8328), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8895), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9849), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9852), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9853), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9855), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9856), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9857), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9859), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9861), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9862), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(5062), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(6899), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(6904), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(6906), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(6924), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 531, DateTimeKind.Utc).AddTicks(447), new DateTime(2025, 7, 21, 6, 43, 29, 531, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 531, DateTimeKind.Utc).AddTicks(1201), new DateTime(2025, 7, 21, 6, 43, 29, 531, DateTimeKind.Utc).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 531, DateTimeKind.Utc).AddTicks(1203), new DateTime(2025, 7, 21, 6, 43, 29, 531, DateTimeKind.Utc).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 531, DateTimeKind.Utc).AddTicks(1205), new DateTime(2025, 7, 21, 6, 43, 29, 531, DateTimeKind.Utc).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 531, DateTimeKind.Utc).AddTicks(1207), new DateTime(2025, 7, 21, 6, 43, 29, 531, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 531, DateTimeKind.Utc).AddTicks(1209), new DateTime(2025, 7, 21, 6, 43, 29, 531, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(2506), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(3609), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(3611), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(3614), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(3615), new DateTime(2025, 7, 21, 6, 43, 29, 530, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_EventId",
                table: "Carts",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98d27459-4250-4135-aabe-fe376a319581");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9081a0c-c993-4ff4-a7f5-7841d4220307");

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
        }
    }
}
