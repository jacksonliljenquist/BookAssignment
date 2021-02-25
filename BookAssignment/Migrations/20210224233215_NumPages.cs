using Microsoft.EntityFrameworkCore.Migrations;

namespace BookAssignment.Migrations
{
    public partial class NumPages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumPages",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumPages",
                table: "Projects");
        }
    }
}
