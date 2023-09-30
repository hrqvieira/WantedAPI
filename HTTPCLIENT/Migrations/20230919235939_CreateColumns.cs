using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HTTPCLIENT.Migrations
{
    /// <inheritdoc />
    public partial class CreateColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Wanteds");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Wanteds",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Eyes",
                table: "Wanteds",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Hair",
                table: "Wanteds",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ScarsAndMarks",
                table: "Wanteds",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Wanteds",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Warning_message",
                table: "Wanteds",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Wanteds");

            migrationBuilder.DropColumn(
                name: "Eyes",
                table: "Wanteds");

            migrationBuilder.DropColumn(
                name: "Hair",
                table: "Wanteds");

            migrationBuilder.DropColumn(
                name: "ScarsAndMarks",
                table: "Wanteds");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Wanteds");

            migrationBuilder.DropColumn(
                name: "Warning_message",
                table: "Wanteds");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Wanteds",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
