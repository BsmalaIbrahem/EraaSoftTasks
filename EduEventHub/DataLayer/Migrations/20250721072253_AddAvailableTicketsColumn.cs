using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddAvailableTicketsColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98d27459-4250-4135-aabe-fe376a319581");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9081a0c-c993-4ff4-a7f5-7841d4220307");

            migrationBuilder.AddColumn<int>(
                name: "AvailableTickets",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "AvailableTickets", "CreatedAt", "UpdatedAt" },
                values: new object[] { 0, new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(8353), new DateTime(2025, 7, 21, 7, 22, 51, 522, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableTickets", "CreatedAt", "UpdatedAt" },
                values: new object[] { 0, new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(343), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvailableTickets", "CreatedAt", "UpdatedAt" },
                values: new object[] { 0, new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(365), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvailableTickets", "CreatedAt", "UpdatedAt" },
                values: new object[] { 0, new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(369), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvailableTickets", "CreatedAt", "UpdatedAt" },
                values: new object[] { 0, new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(371), new DateTime(2025, 7, 21, 7, 22, 51, 523, DateTimeKind.Utc).AddTicks(372) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a12bf58c-2350-49d0-ae7d-73a278fbcb93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bda09337-3f18-48fd-b8f8-ce17023639ce");

            migrationBuilder.DropColumn(
                name: "AvailableTickets",
                table: "Events");

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
        }
    }
}
