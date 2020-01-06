using Microsoft.EntityFrameworkCore.Migrations;

namespace _6._3.Migrations
{
    public partial class CityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Noodles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Noodles");
        }
    }
}
