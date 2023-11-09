using Microsoft.EntityFrameworkCore.Migrations;

namespace AppContext.Migrations
{
    public partial class AddmodelNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "models",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "models",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MasoolAz",
                table: "models",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MasoolTel",
                table: "models",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "models");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "models");

            migrationBuilder.DropColumn(
                name: "MasoolAz",
                table: "models");

            migrationBuilder.DropColumn(
                name: "MasoolTel",
                table: "models");
        }
    }
}
