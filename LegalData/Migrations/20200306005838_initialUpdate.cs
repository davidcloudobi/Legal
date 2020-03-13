using Microsoft.EntityFrameworkCore.Migrations;

namespace LegalData.Migrations
{
    public partial class initialUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Lawyers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Lawyers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Lawyers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Lawyers");
        }
    }
}
