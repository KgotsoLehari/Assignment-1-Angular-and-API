using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace u20530545_HW01_API.Migrations
{
    /// <inheritdoc />
    public partial class d_Courses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 1,
                column: "courseDuration",
                value: "Duration: Semester");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 2,
                column: "courseDuration",
                value: "Duration: Semester 1");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 3,
                column: "courseDuration",
                value: "Duration: Year");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 4,
                column: "courseDuration",
                value: "Duration: Year");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 5,
                column: "courseDuration",
                value: "Duration: Year");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 7,
                column: "courseDuration",
                value: "Duration: Year");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 8,
                column: "courseDuration",
                value: "Duration: Semester 1");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 10,
                column: "courseDuration",
                value: "Duration: Semester");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 1,
                column: "courseDuration",
                value: "Semester");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 2,
                column: "courseDuration",
                value: "Semester 1");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 3,
                column: "courseDuration",
                value: "Year");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 4,
                column: "courseDuration",
                value: "Year");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 5,
                column: "courseDuration",
                value: "Year");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 7,
                column: "courseDuration",
                value: "Year");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 8,
                column: "courseDuration",
                value: "Semester 1");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 10,
                column: "courseDuration",
                value: "Semester");
        }
    }
}
