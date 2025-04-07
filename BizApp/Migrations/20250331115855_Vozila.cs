using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BizApp.Migrations
{
    /// <inheritdoc />
    public partial class Vozila : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vozila",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proizvodjac = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Registracija = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    DatumIstekaRegistracije = table.Column<DateOnly>(type: "date", nullable: false),
                    DatumIstekaProtivPozarnogAparata = table.Column<DateOnly>(type: "date", nullable: false),
                    ProtivProzarniAparat = table.Column<bool>(type: "bit", nullable: false),
                    DatumIstekaPrvePomoci = table.Column<DateOnly>(type: "date", nullable: false),
                    PrvaPomoc = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozila", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vozila",
                schema: "dbo");
        }
    }
}
