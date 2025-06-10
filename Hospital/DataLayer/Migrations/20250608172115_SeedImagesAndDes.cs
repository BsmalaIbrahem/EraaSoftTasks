using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class SeedImagesAndDes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DoctorSchedules",
                columns: new[] { "Id", "CreatedAt", "DayName", "DeletedTime", "DoctorId", "EndTime", "IsDeleted", "StartTime", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, 1, null, 1, new TimeSpan(0, 17, 0, 0, 0), false, new TimeSpan(0, 9, 0, 0, 0), null },
                    { 2, null, 2, null, 1, new TimeSpan(0, 17, 0, 0, 0), false, new TimeSpan(0, 9, 0, 0, 0), null },
                    { 3, null, 3, null, 1, new TimeSpan(0, 17, 0, 0, 0), false, new TimeSpan(0, 9, 0, 0, 0), null },
                    { 4, null, 4, null, 1, new TimeSpan(0, 17, 0, 0, 0), false, new TimeSpan(0, 9, 0, 0, 0), null },
                    { 5, null, 0, null, 1, new TimeSpan(0, 17, 0, 0, 0), false, new TimeSpan(0, 9, 0, 0, 0), null },
                    { 6, null, 3, null, 2, new TimeSpan(0, 17, 0, 0, 0), false, new TimeSpan(0, 9, 0, 0, 0), null },
                    { 7, null, 0, null, 2, new TimeSpan(0, 17, 0, 0, 0), false, new TimeSpan(0, 10, 0, 0, 0), null },
                    { 8, null, 1, null, 2, new TimeSpan(0, 23, 0, 0, 0), false, new TimeSpan(0, 17, 0, 0, 0), null },
                    { 9, null, 3, null, 3, new TimeSpan(0, 17, 0, 0, 0), false, new TimeSpan(0, 9, 0, 0, 0), null },
                    { 10, null, 1, null, 4, new TimeSpan(0, 18, 0, 0, 0), false, new TimeSpan(0, 7, 0, 0, 0), null },
                    { 11, null, 0, null, 4, new TimeSpan(0, 18, 0, 0, 0), false, new TimeSpan(0, 7, 0, 0, 0), null },
                    { 12, null, 2, null, 5, new TimeSpan(0, 18, 0, 0, 0), false, new TimeSpan(0, 7, 0, 0, 0), null },
                    { 13, null, 1, null, 5, new TimeSpan(0, 18, 0, 0, 0), false, new TimeSpan(0, 7, 0, 0, 0), null }
                });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Dr. Ibrahim Awad is a specialist in Internal Medicine with over 10 years of experience in treating various medical conditions. He is known for his patient-centered approach and dedication to improving health outcomes.");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Dr. Ahmed Essawy is a renowned Internal Medicine specialist with a focus on chronic disease management. He has a passion for educating patients about their health and empowering them to take control of their well-being.");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Dr. Mohamed Ali is a dedicated Pediatrician with a love for working with children. He has extensive experience in diagnosing and treating childhood illnesses, and he is committed to providing compassionate care to his young patients.");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Dr. Nader Hamdy is a Pediatric specialist with a focus on developmental disorders. He works closely with families to ensure the best possible outcomes for children with special needs.");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Dr. Mohamed Zaky is a Pediatrician with a passion for child health and wellness. He believes in a holistic approach to healthcare, addressing both physical and emotional needs of his young patients.");

            migrationBuilder.UpdateData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Img" },
                values: new object[] { "Our Internal Medicine department specializes in the prevention, diagnosis, and treatment of adult diseases. Our team of experienced internists provides comprehensive care for a wide range of conditions, including chronic illnesses such as diabetes, hypertension, heart disease, and respiratory disorders.", "Specializations/internal_medicine.jpg" });

            migrationBuilder.UpdateData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Img" },
                values: new object[] { "At our clinic, we offer specialized pediatric care designed to support the health and development of children from infancy through adolescence. Our experienced pediatricians provide comprehensive medical services, including routine check-ups, vaccinations, developmental screenings, treatment of common childhood illnesses, and guidance for parents on nutrition, growth, and behavior.", "Specializations/pediatrics.jpg" });

            migrationBuilder.UpdateData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Img" },
                values: new object[] { "Our surgical department is committed to delivering safe, effective, and compassionate care to patients in need of surgical treatment. We offer a wide range of surgical services—from minor procedures to complex operations—performed by skilled surgeons using the latest techniques and technology.", "Specializations/surgery.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Img" },
                values: new object[] { "Description About Internal Medicine", null });

            migrationBuilder.UpdateData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Img" },
                values: new object[] { "Description About Pediatrics", null });

            migrationBuilder.UpdateData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Img" },
                values: new object[] { "Description About Surgery", null });
        }
    }
}
