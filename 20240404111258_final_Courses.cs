using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace u20530545_HW01_API.Migrations
{
    /// <inheritdoc />
    public partial class final_Courses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 6,
                column: "courseDuration",
                value: "Duration: Semester");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 9,
                column: "courseDuration",
                value: "Duration: Semester");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 6,
                column: "courseDuration",
                value: "Semester");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 9,
                column: "courseDuration",
                value: "Semester");
        }
    }
}
