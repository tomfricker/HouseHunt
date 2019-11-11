using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseHunt.Migrations
{
    public partial class FloorPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FloorPlan",
                table: "Houses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FloorPlan",
                table: "Houses");
        }
    }
}
