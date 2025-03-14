using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BizApp.Migrations
{
    /// <inheritdoc />
    public partial class Konstrukcija : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PKrova",
                schema: "dbo",
                table: "Proizvodi");

            migrationBuilder.DropColumn(
                name: "PPoda",
                schema: "dbo",
                table: "Proizvodi");

            migrationBuilder.DropColumn(
                name: "PZida",
                schema: "dbo",
                table: "Proizvodi");

            migrationBuilder.DropColumn(
                name: "Profil120x60",
                schema: "dbo",
                table: "Proizvodi");

            migrationBuilder.DropColumn(
                name: "Profil40x80",
                schema: "dbo",
                table: "Proizvodi");

            migrationBuilder.CreateTable(
                name: "Konstrukcije",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: true),
                    Profil120x60 = table.Column<int>(type: "int", maxLength: 110, nullable: true),
                    Profil40x80 = table.Column<int>(type: "int", nullable: true),
                    PZida = table.Column<int>(type: "int", nullable: true),
                    PPoda = table.Column<int>(type: "int", nullable: true),
                    PKrova = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konstrukcije", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Konstrukcije",
                schema: "dbo");

            migrationBuilder.AddColumn<int>(
                name: "PKrova",
                schema: "dbo",
                table: "Proizvodi",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PPoda",
                schema: "dbo",
                table: "Proizvodi",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PZida",
                schema: "dbo",
                table: "Proizvodi",
                type: "int",
                nullable: true);

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
    }
}
