using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaApp.Migrations
{
    public partial class removefield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bearbeiten",
                table: "Aufgaben");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Bearbeiten",
                table: "Aufgaben",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
