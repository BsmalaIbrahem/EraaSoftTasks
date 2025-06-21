using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class DeleteTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventSpeakers");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventSpeakers",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    SpeakerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventSpeakers", x => new { x.EventId, x.SpeakerId });
                    table.ForeignKey(
                        name: "FK_EventSpeakers_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventSpeakers_Speakers_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "Speakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(6909), new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7720), new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7723), new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7724), new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7725), new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6419), new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6934), new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6968), new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6972), new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6976), new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6979), new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "EventAgendas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6982), new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(5900), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7067), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7071), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7073), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7074), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7075), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7077), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7078), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7079), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7080), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "EventContent",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7082), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7082) });

            migrationBuilder.InsertData(
                table: "EventSpeakers",
                columns: new[] { "EventId", "SpeakerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 4 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(2123), new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4227), new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4233), new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4237), new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4240), new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7916), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8689), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8692), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8694), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8696), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "SpeakerSocialMedias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8699), new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(4486), new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5782), new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5787), new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5789), new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5816), new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5817) });

            migrationBuilder.CreateIndex(
                name: "IX_EventSpeakers_SpeakerId",
                table: "EventSpeakers",
                column: "SpeakerId");
        }
    }
}
