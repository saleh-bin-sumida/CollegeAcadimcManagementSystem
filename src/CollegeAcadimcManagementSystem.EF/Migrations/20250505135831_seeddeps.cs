using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CollegeAcadimcManagementSystem.EF.Migrations
{
    /// <inheritdoc />
    public partial class seeddeps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumns: new[] { "DepartmentId", "StudyLevelId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "DepartmentStudyLevels",
                columns: new[] { "DepartmentId", "StudyLevelId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "StudyLevels",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Level 3" },
                    { 4, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Level 4" },
                    { 5, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Level 5" },
                    { 6, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Level 6" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentStudyLevels",
                columns: new[] { "DepartmentId", "StudyLevelId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumns: new[] { "DepartmentId", "StudyLevelId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumns: new[] { "DepartmentId", "StudyLevelId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumns: new[] { "DepartmentId", "StudyLevelId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumns: new[] { "DepartmentId", "StudyLevelId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumns: new[] { "DepartmentId", "StudyLevelId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumns: new[] { "DepartmentId", "StudyLevelId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumns: new[] { "DepartmentId", "StudyLevelId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumns: new[] { "DepartmentId", "StudyLevelId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumns: new[] { "DepartmentId", "StudyLevelId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "StudyLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudyLevels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StudyLevels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudyLevels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "DepartmentStudyLevels",
                columns: new[] { "DepartmentId", "StudyLevelId" },
                values: new object[] { 3, 2 });
        }
    }
}
