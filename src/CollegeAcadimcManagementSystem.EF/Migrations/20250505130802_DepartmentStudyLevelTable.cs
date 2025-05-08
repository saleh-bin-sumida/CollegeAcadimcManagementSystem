using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CollegeAcadimcManagementSystem.EF.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentStudyLevelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentStudyLevels",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    StudyLevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentStudyLevels", x => new { x.DepartmentId, x.StudyLevelId });
                    table.ForeignKey(
                        name: "FK_DepartmentStudyLevels_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentStudyLevels_StudyLevels_StudyLevelId",
                        column: x => x.StudyLevelId,
                        principalTable: "StudyLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DepartmentStudyLevels",
                columns: new[] { "DepartmentId", "StudyLevelId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentStudyLevels_StudyLevelId",
                table: "DepartmentStudyLevels",
                column: "StudyLevelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentStudyLevels");
        }
    }
}
