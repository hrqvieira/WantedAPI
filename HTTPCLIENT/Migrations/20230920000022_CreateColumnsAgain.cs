using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HTTPCLIENT.Migrations
{
    /// <inheritdoc />
    public partial class CreateColumnsAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Wanteds",
                newName: "WantedDescription");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WantedDescription",
                table: "Wanteds",
                newName: "Description");
        }
    }
}
