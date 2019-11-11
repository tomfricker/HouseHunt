using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseHunt.Migrations
{
    public partial class AddSoldPropertyToHouseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Sold",
                table: "Houses",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sold",
                table: "Houses");
        }
    }
}
