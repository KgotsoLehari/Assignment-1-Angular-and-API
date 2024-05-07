using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace u20530545_HW01_API.Migrations
{
    /// <inheritdoc />
    public partial class NewCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 1,
                column: "courseDescription",
                value: "Description: Year 1 , Semester 1 , Academic Information Management");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 2,
                column: "courseDescription",
                value: "Description: Accounting Principles");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 3,
                column: "courseDescription",
                value: "Description: Introduction to API's");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 4,
                column: "courseDescription",
                value: "Description: Advanced Programming");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 5,
                column: "courseDescription",
                value: "Description: Taxonomies");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 6,
                column: "courseDescription",
                value: "Description: Year 2 , Semester 1 , Academic Information Management");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 7,
                column: "courseDescription",
                value: "Description: Year 3. Project");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 8,
                column: "courseDescription",
                value: "Description: Introduction to API's");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 9,
                column: "courseDescription",
                value: "Description: Year 3 , Semester 2 , IT Trends");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 10,
                column: "courseDescription",
                value: "Description: Year 3 , Semester 1 . Programming Management");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 1,
                column: "courseDescription",
                value: "Year 1 , Semester 1 , Academic Information Management");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 2,
                column: "courseDescription",
                value: "Accounting Principles");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 3,
                column: "courseDescription",
                value: "Introduction to API's");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 4,
                column: "courseDescription",
                value: "Advanced Programming");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 5,
                column: "courseDescription",
                value: "Taxonomies");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 6,
                column: "courseDescription",
                value: "Year 2 , Semester 1 , Academic Information Management");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 7,
                column: "courseDescription",
                value: "Year 3. Project");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 8,
                column: "courseDescription",
                value: "Introduction to API's");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 9,
                column: "courseDescription",
                value: "Year 3 , Semester 2 , IT Trends");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 10,
                column: "courseDescription",
                value: "Year 3 , Semester 1 . Programming Management");
        }
    }
}
