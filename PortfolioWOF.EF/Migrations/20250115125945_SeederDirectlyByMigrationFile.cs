using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioWOF.EF.Migrations
{
    /// <inheritdoc />
    public partial class SeederDirectlyByMigrationFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // this is fist way to seeding data to Database 
            // the second way is by do that in OnModelCreation in DBcontext 
            migrationBuilder.InsertData(
               table: "PersonalInfos",
               columns: new[] { "Id", "Name", "Email", "Phone", "Address", "Bio", "About", "ImageUrl" },
               values: new object[] { 1, "omar", "omar@example.com", "1234567890", "123 Main St", "Software Developer", "Passionate about technology", null }

             );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
