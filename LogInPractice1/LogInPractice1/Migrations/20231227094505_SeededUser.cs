using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogInPractice1.Migrations
{
    /// <inheritdoc />
    public partial class SeededUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { -1, "123", "hasan" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
