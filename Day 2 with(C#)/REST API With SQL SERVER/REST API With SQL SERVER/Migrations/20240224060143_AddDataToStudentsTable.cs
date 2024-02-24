using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace REST_API_With_SQL_SERVER.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToStudentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "Mihirkumargupta2@gmail.com", "Mihir Gupta" },
                    { 2, "Khushigupta2@gmail.com", "Khushi Gupta" },
                    { 3, "Anjalishaw4@gmail.com", "Anjali Shaw" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
