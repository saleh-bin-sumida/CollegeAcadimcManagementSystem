﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeAcadimcManagementSystem.EF.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentStudyLevelCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentStudyLevelCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    DepartmentStudyLevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentStudyLevelCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentStudyLevelCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentStudyLevelCourses_DepartmentStudyLevels_DepartmentStudyLevelId",
                        column: x => x.DepartmentStudyLevelId,
                        principalTable: "DepartmentStudyLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentStudyLevelCourses_CourseId",
                table: "DepartmentStudyLevelCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentStudyLevelCourses_DepartmentStudyLevelId",
                table: "DepartmentStudyLevelCourses",
                column: "DepartmentStudyLevelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentStudyLevelCourses");
        }
    }
}
