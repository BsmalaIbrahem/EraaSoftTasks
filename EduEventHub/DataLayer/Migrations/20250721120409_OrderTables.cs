using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class OrderTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a12bf58c-2350-49d0-ae7d-73a278fbcb93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bda09337-3f18-48fd-b8f8-ce17023639ce");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventOrders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventOrders", x => new { x.OrderId, x.EventId });
                    table.ForeignKey(
                        name: "FK_EventOrders_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f34ea44-06c3-4091-ab7a-0b1c761320e1", null, "Admin", "ADMIN" },
                    { "924a141b-6abe-401e-b537-42088aa07ff0", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ef1ebe7-f79f-4cda-ad06-b7e1ff9c6a9a", "AQAAAAIAAYagAAAAEDvR++jDfN0K1vbeP7/0ywUqV1q9UighbTLLxWCDLZWWrjRS7LhQU8zvI2hj2+I/iw==", "74480221-d171-4da4-8ffd-429a6c0d87e6" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 807, DateTimeKind.Utc).AddTicks(7908), new DateTime(2025, 7, 21, 12, 4, 4, 807, DateTimeKind.Utc).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 807, DateTimeKind.Utc).AddTicks(8685), new DateTime(2025, 7, 21, 12, 4, 4, 807, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 807, DateTimeKind.Utc).AddTicks(8706), new DateTime(2025, 7, 21, 12, 4, 4, 807, DateTimeKind.Utc).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 807, DateTimeKind.Utc).AddTicks(8707), new DateTime(2025, 7, 21, 12, 4, 4, 807, DateTimeKind.Utc).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 807, DateTimeKind.Utc).AddTicks(8708), new DateTime(2025, 7, 21, 12, 4, 4, 807, DateTimeKind.Utc).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(1673), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(2564), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(2600), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(2602), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(2604), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(2606), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(2608), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(3389), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4874), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4877), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4879), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4881), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4883), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4885), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4886), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4887), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4958), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4961), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 808, DateTimeKind.Utc).AddTicks(8456), new DateTime(2025, 7, 21, 12, 4, 4, 808, DateTimeKind.Utc).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(672), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(678), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(682), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(685), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(5825), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(6858), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(6862), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(6866), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(6868), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(6871), new DateTime(2025, 7, 21, 12, 4, 4, 809, DateTimeKind.Utc).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 808, DateTimeKind.Utc).AddTicks(5654), new DateTime(2025, 7, 21, 12, 4, 4, 808, DateTimeKind.Utc).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 808, DateTimeKind.Utc).AddTicks(6864), new DateTime(2025, 7, 21, 12, 4, 4, 808, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 808, DateTimeKind.Utc).AddTicks(6867), new DateTime(2025, 7, 21, 12, 4, 4, 808, DateTimeKind.Utc).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 808, DateTimeKind.Utc).AddTicks(6868), new DateTime(2025, 7, 21, 12, 4, 4, 808, DateTimeKind.Utc).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 12, 4, 4, 808, DateTimeKind.Utc).AddTicks(6871), new DateTime(2025, 7, 21, 12, 4, 4, 808, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.CreateIndex(
                name: "IX_EventOrders_EventId",
                table: "EventOrders",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventOrders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f34ea44-06c3-4091-ab7a-0b1c761320e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "924a141b-6abe-401e-b537-42088aa07ff0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a12bf58c-2350-49d0-ae7d-73a278fbcb93", null, "User", "USER" },
                    { "bda09337-3f18-48fd-b8f8-ce17023639ce", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f59ededa-7503-40b1-b71a-e39a2efbf128", "AQAAAAIAAYagAAAAEJuzfg5QBdCHZNg2H+ltO3UDoLklNqicJ4Xg4azzXTXXoHvE/xKKcnN3DQqIf6p0EQ==", "d40b2052-3825-4c88-8e39-53f6079d968f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 521, DateTimeKind.Utc).AddTicks(6869), new DateTime(2025, 7, 21, 7, 22, 51, 521, DateTimeKind.Utc).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 521, DateTimeKind.Utc).AddTicks(7751), new DateTime(2025, 7, 21, 7, 22, 51, 521, DateTimeKind.Utc).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 521, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 7, 21, 7, 22, 51, 521, DateTimeKind.Utc).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 521, DateTimeKind.Utc).AddTicks(7755), new DateTime(2025, 7, 21, 7, 22, 51, 521, DateTimeKind.Utc).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 521, DateTimeKind.Utc).AddTicks(7756), new DateTime(2025, 7, 21, 7, 22, 51, 521, DateTimeKind.Utc).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1233), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1951), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1955), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1957), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1959), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1961), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1962), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(2731), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3829), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3832), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3835), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3836), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3837), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3839), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3840), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3842), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3843), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3844), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(8353), new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(343), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(365), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(369), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(371), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(4529), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(5470), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(5472), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(5475), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(5477), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(5479), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(5244), new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(6608), new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(6612), new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(6614), new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(6615), new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(6615) });
        }
    }
}
