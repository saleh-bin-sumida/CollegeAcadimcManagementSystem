using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeAcadimcManagementSystem.EF.Migrations
{
    /// <inheritdoc />
    public partial class edite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentEnrollments_DepartmentStudyLevels_DepartmentStudyLevelId",
                table: "StudentEnrollments");

            migrationBuilder.RenameColumn(
                name: "DepartmentStudyLevelId",
                table: "StudentEnrollments",
                newName: "DepartmentStudyLevelCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentEnrollments_DepartmentStudyLevelId",
                table: "StudentEnrollments",
                newName: "IX_StudentEnrollments_DepartmentStudyLevelCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentEnrollments_DepartmentStudyLevelCourses_DepartmentStudyLevelCourseId",
                table: "StudentEnrollments",
                column: "DepartmentStudyLevelCourseId",
                principalTable: "DepartmentStudyLevelCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentEnrollments_DepartmentStudyLevelCourses_DepartmentStudyLevelCourseId",
                table: "StudentEnrollments");

            migrationBuilder.RenameColumn(
                name: "DepartmentStudyLevelCourseId",
                table: "StudentEnrollments",
                newName: "DepartmentStudyLevelId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentEnrollments_DepartmentStudyLevelCourseId",
                table: "StudentEnrollments",
                newName: "IX_StudentEnrollments_DepartmentStudyLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentEnrollments_DepartmentStudyLevels_DepartmentStudyLevelId",
                table: "StudentEnrollments",
                column: "DepartmentStudyLevelId",
                principalTable: "DepartmentStudyLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
