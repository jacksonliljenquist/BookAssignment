using Microsoft.EntityFrameworkCore.Migrations;

namespace BookAssignment.Migrations
{
    public partial class website : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WebLink",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WebLink",
                table: "Projects");
        }
    }
}
