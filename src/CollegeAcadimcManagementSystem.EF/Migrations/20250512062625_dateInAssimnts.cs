using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeAcadimcManagementSystem.EF.Migrations
{
    /// <inheritdoc />
    public partial class dateInAssimnts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "CourseInstructorAssignments",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateOnly(2023, 10, 1));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateOnly(2023, 10, 2));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateOnly(2023, 10, 3));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateOnly(2023, 10, 4));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateOnly(2023, 10, 5));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateOnly(2023, 10, 6));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateOnly(2023, 10, 7));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateOnly(2023, 10, 8));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateOnly(2023, 10, 9));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateOnly(2023, 10, 10));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateOnly(2023, 10, 11));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateOnly(2023, 10, 12));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateOnly(2023, 10, 13));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateOnly(2023, 10, 14));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateOnly(2023, 10, 15));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateOnly(2023, 10, 16));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateOnly(2023, 10, 17));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateOnly(2023, 10, 18));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateOnly(2023, 10, 19));

            migrationBuilder.UpdateData(
                table: "CourseInstructorAssignments",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateOnly(2023, 10, 20));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "CourseInstructorAssignments");
        }
    }
}
