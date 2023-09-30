using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HTTPCLIENT.Migrations
{
    /// <inheritdoc />
    public partial class CreateCloudeDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Teste",
                table: "Wanteds",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Teste",
                table: "Wanteds");
        }
    }
}
