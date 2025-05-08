using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CollegeAcadimcManagementSystem.EF.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentStudyLevelId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentStudyLevels",
                table: "DepartmentStudyLevels");

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumns: new[] { "DepartmentId", "StudyLevelId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumns: new[] { "DepartmentId", "StudyLevelId" },
                keyValues: new object[] { 1, 2 });

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
                keyValues: new object[] { 2, 1 });

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

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DepartmentStudyLevels",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentStudyLevels",
                table: "DepartmentStudyLevels",
                column: "Id");

            migrationBuilder.InsertData(
                table: "DepartmentStudyLevels",
                columns: new[] { "Id", "DepartmentId", "StudyLevelId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 2, 1 },
                    { 8, 2, 2 },
                    { 9, 2, 3 },
                    { 10, 3, 4 },
                    { 11, 3, 5 },
                    { 12, 3, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentStudyLevels_DepartmentId",
                table: "DepartmentStudyLevels",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentStudyLevels",
                table: "DepartmentStudyLevels");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentStudyLevels_DepartmentId",
                table: "DepartmentStudyLevels");

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DepartmentStudyLevels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DepartmentStudyLevels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentStudyLevels",
                table: "DepartmentStudyLevels",
                columns: new[] { "DepartmentId", "StudyLevelId" });

            migrationBuilder.InsertData(
                table: "DepartmentStudyLevels",
                columns: new[] { "DepartmentId", "StudyLevelId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 }
                });
        }
    }
}
