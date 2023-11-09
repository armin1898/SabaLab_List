using Microsoft.EntityFrameworkCore.Migrations;

namespace AppContext.Migrations
{
    public partial class AddNew2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BackupSync",
                table: "models",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LabManagerOnline",
                table: "models",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastMoney",
                table: "models",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Media",
                table: "models",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MediaQR",
                table: "models",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Qc",
                table: "models",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ResponseOnline",
                table: "models",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sms",
                table: "models",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Storage",
                table: "models",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackupSync",
                table: "models");

            migrationBuilder.DropColumn(
                name: "LabManagerOnline",
                table: "models");

            migrationBuilder.DropColumn(
                name: "LastMoney",
                table: "models");

            migrationBuilder.DropColumn(
                name: "Media",
                table: "models");

            migrationBuilder.DropColumn(
                name: "MediaQR",
                table: "models");

            migrationBuilder.DropColumn(
                name: "Qc",
                table: "models");

            migrationBuilder.DropColumn(
                name: "ResponseOnline",
                table: "models");

            migrationBuilder.DropColumn(
                name: "Sms",
                table: "models");

            migrationBuilder.DropColumn(
                name: "Storage",
                table: "models");
        }
    }
}
