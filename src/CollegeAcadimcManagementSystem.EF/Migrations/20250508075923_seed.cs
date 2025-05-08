using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CollegeAcadimcManagementSystem.EF.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Mathematics 101" },
                    { 2, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Physics 101" },
                    { 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Chemistry 101" },
                    { 4, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Biology 101" },
                    { 5, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Computer Science 101" },
                    { 6, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "History 101" },
                    { 7, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Philosophy 101" },
                    { 8, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Economics 101" },
                    { 9, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Statistics 101" },
                    { 10, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "Literature 101" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentStudyLevelCourses",
                columns: new[] { "Id", "CourseId", "DepartmentStudyLevelId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 2 },
                    { 4, 4, 2 },
                    { 5, 5, 3 },
                    { 6, 6, 3 },
                    { 7, 7, 4 },
                    { 8, 8, 4 },
                    { 9, 9, 5 },
                    { 10, 10, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevelCourses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevelCourses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevelCourses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevelCourses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevelCourses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevelCourses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevelCourses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevelCourses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevelCourses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevelCourses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
