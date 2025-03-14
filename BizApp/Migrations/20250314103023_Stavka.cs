using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BizApp.Migrations
{
    /// <inheritdoc />
    public partial class Stavka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stavke",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FakturaKonstrukcijaID = table.Column<int>(type: "int", nullable: false),
                    ProizvodID = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    Naručeno = table.Column<bool>(type: "bit", nullable: true),
                    Montirano = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stavke", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Stavke_FakturaKonstrikcije_FakturaKonstrukcijaID",
                        column: x => x.FakturaKonstrukcijaID,
                        principalSchema: "dbo",
                        principalTable: "FakturaKonstrikcije",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stavke_Proizvodi_ProizvodID",
                        column: x => x.ProizvodID,
                        principalSchema: "dbo",
                        principalTable: "Proizvodi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stavke_FakturaKonstrukcijaID",
                schema: "dbo",
                table: "Stavke",
                column: "FakturaKonstrukcijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Stavke_ProizvodID",
                schema: "dbo",
                table: "Stavke",
                column: "ProizvodID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stavke",
                schema: "dbo");
        }
    }
}
