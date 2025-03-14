using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BizApp.Migrations
{
    /// <inheritdoc />
    public partial class FakturaKonstrukcija : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FakturaKonstrikcije",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KonstrikcijaID = table.Column<int>(type: "int", nullable: false),
                    FakturaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FakturaKonstrikcije", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FakturaKonstrikcije_Fakture_FakturaID",
                        column: x => x.FakturaID,
                        principalSchema: "dbo",
                        principalTable: "Fakture",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FakturaKonstrikcije_Konstrukcije_KonstrikcijaID",
                        column: x => x.KonstrikcijaID,
                        principalSchema: "dbo",
                        principalTable: "Konstrukcije",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FakturaKonstrikcije_FakturaID",
                schema: "dbo",
                table: "FakturaKonstrikcije",
                column: "FakturaID");

            migrationBuilder.CreateIndex(
                name: "IX_FakturaKonstrikcije_KonstrikcijaID",
                schema: "dbo",
                table: "FakturaKonstrikcije",
                column: "KonstrikcijaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FakturaKonstrikcije",
                schema: "dbo");
        }
    }
}
