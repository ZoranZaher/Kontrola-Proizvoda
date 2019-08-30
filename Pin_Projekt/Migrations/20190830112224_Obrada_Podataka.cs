using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pin_Projekt.Migrations
{
    public partial class Obrada_Podataka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Obrada_Podataka",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime_Proizvoda = table.Column<string>(nullable: true),
                    Tržište = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Etiketa = table.Column<string>(nullable: true),
                    Čep = table.Column<int>(nullable: false),
                    Izgled_Proizvoda = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obrada_Podataka", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Obrada_Podataka");
        }
    }
}
