using Microsoft.EntityFrameworkCore.Migrations;

namespace GuardaCapitalEuropeia.Migrations
{
    public partial class Restaurante1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Contact",
                table: "Restaurantes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Contacto",
                table: "Restaurantes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Restaurantes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Restaurantes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Restaurantes");

            migrationBuilder.DropColumn(
                name: "Contacto",
                table: "Restaurantes");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Restaurantes");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Restaurantes");
        }
    }
}
