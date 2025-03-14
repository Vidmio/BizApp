using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BizApp.Migrations
{
    /// <inheritdoc />
    public partial class ProizvodiProfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Profil120x60",
                schema: "dbo",
                table: "Proizvodi",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Profil40x80",
                schema: "dbo",
                table: "Proizvodi",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profil120x60",
                schema: "dbo",
                table: "Proizvodi");

            migrationBuilder.DropColumn(
                name: "Profil40x80",
                schema: "dbo",
                table: "Proizvodi");
        }
    }
}
