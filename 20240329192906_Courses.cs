using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace u20530545_HW01_API.Migrations
{
    /// <inheritdoc />
    public partial class Courses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    courseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    courseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    courseDuration = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.courseId);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "courseId", "courseDescription", "courseDuration", "courseName" },
                values: new object[,]
                {
                    { 1, "Year 1 , Semester 1 , Academic Information Management", "Semester", "AIM 101" },
                    { 2, "Accounting Principles", "Semester 1", "FRK 113" },
                    { 3, "Introduction to API's", "Year", "INF 200" },
                    { 4, "Advanced Programming", "Year", "INF 345" },
                    { 5, "Taxonomies", "Year", "INF 200" },
                    { 6, "Year 2 , Semester 1 , Academic Information Management", "Semester", "INF 345" },
                    { 7, "Year 3. Project", "Year", "INF 370" },
                    { 8, "Introduction to API's", "Semester 1", "INF 354" },
                    { 9, "Year 3 , Semester 2 , IT Trends", "Semester", "INF 324" },
                    { 10, "Year 3 , Semester 1 . Programming Management", "Semester", "INF 315" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
