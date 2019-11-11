using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseHunt.Migrations
{
    public partial class Favourite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "Houses");

            migrationBuilder.AddColumn<bool>(
                name: "Favourite",
                table: "Houses",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Favourite",
                table: "Houses");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Houses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "Houses",
                nullable: true);
        }
    }
}
