using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Advance_SQL_SERVER_with_API.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToStudentsTabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "age", "name" },
                values: new object[,]
                {
                    { 1, 21, "Test" },
                    { 2, 22, "Test2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
