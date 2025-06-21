using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class initialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpeakerSocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeakerId = table.Column<int>(type: "int", nullable: false),
                    Platform = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeakerSocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpeakerSocialMedias_Speakers_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "Speakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventAgendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAgendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventAgendas_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "EventContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventAgendaId = table.Column<int>(type: "int", nullable: false),
                    SpeakerId = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventContent_EventAgendas_EventAgendaId",
                        column: x => x.EventAgendaId,
                        principalTable: "EventAgendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventContent_Speakers_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "Speakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(6909), null, "Hands-on learning sessions", true, false, "Workshops", new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(6914) },
                    { 2, new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7720), null, "Educational talks by experts", true, false, "Lectures", new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7721) },
                    { 3, new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7723), null, "Cultural and scientific displays", true, false, "Exhibitions", new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7723) },
                    { 4, new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7724), null, "Multi-day events with multiple speakers", true, false, "Conferences", new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7724) },
                    { 5, new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7725), null, "Focused discussions on specific topics", true, false, "Seminars", new DateTime(2025, 6, 21, 14, 25, 6, 173, DateTimeKind.Utc).AddTicks(7725) }
                });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "Id", "Bio", "CreatedAt", "DeletedAt", "ImgPath", "IsActive", "IsDeleted", "Name", "Specialization", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Software engineering expert with over 10 years of experience.", new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(4486), null, "assets/images/speakers/single-speaker.jpg", true, false, "Ahmed Khaled", "Software Development", new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(4488) },
                    { 2, "Data science enthusiast and AI researcher.", new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5782), null, "assets/images/speakers/speaker-five.jpg", true, false, "Mohamed Ali", "Data Science", new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5783) },
                    { 3, "Specialist in educational workshops with a focus on interactive learning.", new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5787), null, "assets/images/speakers/speaker-full-five.jpg", true, false, "Omar Mostafa", "Education", new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5788) },
                    { 4, "Expert in cloud computing and distributed systems.", new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5789), null, "assets/images/speakers/speaker-full-one.jpg", true, false, "Hassan Ibrahim", "Cloud Computing", new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5790) },
                    { 5, "Cybersecurity specialist with a focus on ethical hacking.", new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5816), null, "assets/images/speakers/speaker-full-three.jpg", true, false, "Youssef Sami", "Cybersecurity", new DateTime(2025, 6, 21, 14, 25, 6, 174, DateTimeKind.Utc).AddTicks(5817) }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "DeletedAt", "Description", "EndDate", "ImgPath", "IsActive", "IsDeleted", "Price", "StartDate", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(2123), null, "A hands-on workshop to learn Python programming from scratch.", new DateTime(2024, 10, 16, 16, 0, 0, 0, DateTimeKind.Utc), "assets/images/gallery/gallery-less-eight.jpg", true, false, 50.0, new DateTime(2024, 10, 15, 10, 0, 0, 0, DateTimeKind.Utc), "Python Workshop", new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(2125) },
                    { 2, 2, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4227), null, "Explore the future of artificial intelligence with leading experts.", new DateTime(2025, 1, 20, 17, 0, 0, 0, DateTimeKind.Utc), "assets/images/gallery/gallery-full-seven.jpg", true, false, 30.0, new DateTime(2025, 1, 20, 14, 0, 0, 0, DateTimeKind.Utc), "AI Lecture Series", new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4227) },
                    { 3, 3, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4233), null, "Showcasing the latest innovations in technology.", new DateTime(2025, 6, 12, 18, 0, 0, 0, DateTimeKind.Utc), "assets/images/background/cta-ticket-bg.jpg", true, false, 20.0, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Utc), "Tech Exhibition 2025", new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4234) },
                    { 4, 4, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4237), null, "A conference on cloud solutions and scalability.", new DateTime(2023, 11, 7, 17, 0, 0, 0, DateTimeKind.Utc), "assets/images/background/homepage-one-banner.jpg", true, false, 100.0, new DateTime(2023, 11, 5, 9, 0, 0, 0, DateTimeKind.Utc), "Cloud Computing Conference", new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4237) },
                    { 5, 5, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4240), null, "Learn about the latest trends in cybersecurity.", new DateTime(2026, 3, 15, 15, 0, 0, 0, DateTimeKind.Utc), "assets/images/background/timer-bg.jpg", true, false, 40.0, new DateTime(2026, 3, 15, 10, 0, 0, 0, DateTimeKind.Utc), "Cybersecurity Seminar", new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(4240) }
                });

            migrationBuilder.InsertData(
                table: "SpeakerSocialMedias",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "Platform", "SpeakerId", "UpdatedAt", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7916), null, true, false, 2, 1, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7916), "https://linkedin.com/in/ahmedkhaled" },
                    { 2, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8689), null, true, false, 1, 1, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8689), "https://twitter.com/ahmedkhaled" },
                    { 3, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8692), null, true, false, 1, 2, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8692), "https://twitter.com/mohamedali" },
                    { 4, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8694), null, true, false, 3, 3, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8694), "https://instagram.com/omarmostafa" },
                    { 5, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8696), null, true, false, 2, 4, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8696), "https://linkedin.com/in/hassanibrahim" },
                    { 6, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8699), null, true, false, 1, 5, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(8699), "https://twitter.com/youssefsami" }
                });

            migrationBuilder.InsertData(
                table: "EventAgendas",
                columns: new[] { "Id", "CreatedAt", "Date", "DeletedAt", "EventId", "IsActive", "IsDeleted", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6419), new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, 1, true, false, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6419) },
                    { 2, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6934), new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Utc), null, 1, true, false, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6934) },
                    { 3, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6968), new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), null, 2, true, false, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6969) },
                    { 4, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6972), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, 3, true, false, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6973) },
                    { 5, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6976), new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, 3, true, false, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6976) },
                    { 6, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6979), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), null, 4, true, false, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6979) },
                    { 7, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6982), new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, 5, true, false, new DateTime(2025, 6, 21, 14, 25, 6, 175, DateTimeKind.Utc).AddTicks(6982) }
                });

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

            migrationBuilder.InsertData(
                table: "EventContent",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EventAgendaId", "IsActive", "IsDeleted", "SpeakerId", "StartTime", "Subject", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(5900), null, 1, true, false, 1, new TimeOnly(10, 0, 0), "Introduction to Python Programming", new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(5903) },
                    { 2, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7067), null, 1, true, false, 3, new TimeOnly(14, 0, 0), "Python for Data Science", new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7068) },
                    { 3, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7071), null, 2, true, false, 1, new TimeOnly(11, 0, 0), "Advanced Python Techniques", new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7071) },
                    { 4, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7073), null, 3, true, false, 2, new TimeOnly(14, 0, 0), "Machine Learning Fundamentals", new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7073) },
                    { 5, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7074), null, 3, true, false, 4, new TimeOnly(16, 0, 0), "AI in Cloud Computing", new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7074) },
                    { 6, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7075), null, 4, true, false, 1, new TimeOnly(9, 30, 0), "Innovations in Software Development", new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7076) },
                    { 7, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7077), null, 4, true, false, 2, new TimeOnly(13, 0, 0), "AI-Powered Innovations", new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7077) },
                    { 8, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7078), null, 5, true, false, 4, new TimeOnly(10, 0, 0), "Cloud Solutions Showcase", new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7078) },
                    { 9, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7079), null, 6, true, false, 4, new TimeOnly(9, 0, 0), "Scalable Cloud Architectures", new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7079) },
                    { 10, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7080), null, 6, true, false, 5, new TimeOnly(11, 30, 0), "Securing Cloud Infrastructure", new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7081) },
                    { 11, new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7082), null, 7, true, false, 5, new TimeOnly(10, 0, 0), "Ethical Hacking Techniques", new DateTime(2025, 6, 21, 14, 25, 6, 180, DateTimeKind.Utc).AddTicks(7082) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventAgendas_EventId",
                table: "EventAgendas",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventContent_EventAgendaId",
                table: "EventContent",
                column: "EventAgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_EventContent_SpeakerId",
                table: "EventContent",
                column: "SpeakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSpeakers_SpeakerId",
                table: "EventSpeakers",
                column: "SpeakerId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeakerSocialMedias_SpeakerId",
                table: "SpeakerSocialMedias",
                column: "SpeakerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventContent");

            migrationBuilder.DropTable(
                name: "EventSpeakers");

            migrationBuilder.DropTable(
                name: "SpeakerSocialMedias");

            migrationBuilder.DropTable(
                name: "EventAgendas");

            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
