using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aufgaben",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(maxLength: 20, nullable: false),
                    ErledigtBis = table.Column<DateTime>(nullable: false),
                    Erledigt = table.Column<bool>(nullable: false),
                    Bearbeiten = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aufgaben", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aufgaben");
        }
    }
}
