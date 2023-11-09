using Microsoft.EntityFrameworkCore.Migrations;

namespace AppContext.Migrations
{
    public partial class AddNew1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EndOfSupport",
                table: "models",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndOfSupport",
                table: "models");
        }
    }
}
