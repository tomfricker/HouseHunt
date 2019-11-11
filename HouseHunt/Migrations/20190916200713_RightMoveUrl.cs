using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseHunt.Migrations
{
    public partial class RightMoveUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RightMoveUrl",
                table: "Houses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RightMoveUrl",
                table: "Houses");
        }
    }
}
