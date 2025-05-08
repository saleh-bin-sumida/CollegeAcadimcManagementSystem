using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CollegeAcadimcManagementSystem.EF.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentStudyLevelCoursesInstrucor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepStudyLevelCourseInstructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    DepStudyLevelCourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepStudyLevelCourseInstructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepStudyLevelCourseInstructors_DepartmentStudyLevelCourses_DepStudyLevelCourseId",
                        column: x => x.DepStudyLevelCourseId,
                        principalTable: "DepartmentStudyLevelCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepStudyLevelCourseInstructors_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DepStudyLevelCourseInstructors",
                columns: new[] { "Id", "DepStudyLevelCourseId", "InstructorId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 6, 6 },
                    { 7, 7, 7 },
                    { 8, 8, 8 },
                    { 9, 9, 9 },
                    { 10, 10, 10 },
                    { 11, 1, 11 },
                    { 12, 2, 12 },
                    { 13, 3, 13 },
                    { 14, 4, 14 },
                    { 15, 5, 15 },
                    { 16, 6, 16 },
                    { 17, 7, 17 },
                    { 18, 8, 18 },
                    { 19, 9, 19 },
                    { 20, 10, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepStudyLevelCourseInstructors_DepStudyLevelCourseId",
                table: "DepStudyLevelCourseInstructors",
                column: "DepStudyLevelCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_DepStudyLevelCourseInstructors_InstructorId",
                table: "DepStudyLevelCourseInstructors",
                column: "InstructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepStudyLevelCourseInstructors");
        }
    }
}
