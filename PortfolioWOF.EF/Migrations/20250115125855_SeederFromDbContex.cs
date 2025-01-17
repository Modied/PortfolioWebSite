using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioWOF.EF.Migrations
{
    /// <inheritdoc />
    public partial class SeederFromDbContex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PersonalInfos",
                columns: new[] { "Id", "About", "Address", "Bio", "Email", "ImageUrl", "Name", "Phone" },
                values: new object[] { 2, "Loves creativity and design", "456 Elm St", "Graphic Designer", "janesmith@example.com", null, "Jane Smith", "0987654321" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonalInfos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
