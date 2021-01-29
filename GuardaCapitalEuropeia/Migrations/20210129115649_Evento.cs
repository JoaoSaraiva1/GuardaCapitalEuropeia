using Microsoft.EntityFrameworkCore.Migrations;

namespace GuardaCapitalEuropeia.Migrations
{
    public partial class Evento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Evento",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Evento");
        }
    }
}
