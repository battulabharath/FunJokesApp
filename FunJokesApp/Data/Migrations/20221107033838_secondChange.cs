using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FunJokesApp.Data.Migrations
{
    public partial class secondChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "Joke");
        }
    }
}
