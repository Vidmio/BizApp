using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BizApp.Migrations
{
    /// <inheritdoc />
    public partial class Proizvodi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proizvodi",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Jedinica = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Kolicina = table.Column<int>(type: "int", nullable: true),
                    JedinicnaCena = table.Column<int>(type: "int", nullable: true),
                    GrupaProizvodID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Proizvodi_GrupaProizvoda_GrupaProizvodID",
                        column: x => x.GrupaProizvodID,
                        principalSchema: "dbo",
                        principalTable: "GrupaProizvoda",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_GrupaProizvodID",
                schema: "dbo",
                table: "Proizvodi",
                column: "GrupaProizvodID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proizvodi",
                schema: "dbo");
        }
    }
}
