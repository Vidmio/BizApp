using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BizApp.Migrations
{
    /// <inheritdoc />
    public partial class lager : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Errors",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Errors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GrupaProizvoda",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sortiranje = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupaProizvoda", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Klijenti",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIB = table.Column<int>(type: "int", nullable: true),
                    MaticniBR = table.Column<int>(type: "int", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefon1 = table.Column<int>(type: "int", nullable: true),
                    Telefon2 = table.Column<int>(type: "int", nullable: true),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijenti", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });

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

            migrationBuilder.CreateTable(
                name: "Fakture",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KlijentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakture", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Fakture_Klijenti_KlijentID",
                        column: x => x.KlijentID,
                        principalSchema: "dbo",
                        principalTable: "Klijenti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lageri",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    ProizvodID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lageri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lageri_Proizvodi_ProizvodID",
                        column: x => x.ProizvodID,
                        principalSchema: "dbo",
                        principalTable: "Proizvodi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stavke",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FakturaID = table.Column<int>(type: "int", nullable: false),
                    ProizvodID = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    Naruceno = table.Column<bool>(type: "bit", nullable: true),
                    Montirano = table.Column<bool>(type: "bit", nullable: true),
                    Cena = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stavke", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Stavke_Fakture_FakturaID",
                        column: x => x.FakturaID,
                        principalSchema: "dbo",
                        principalTable: "Fakture",
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
                name: "IX_Fakture_KlijentID",
                schema: "dbo",
                table: "Fakture",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_Lageri_ProizvodID",
                schema: "dbo",
                table: "Lageri",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_GrupaProizvodID",
                schema: "dbo",
                table: "Proizvodi",
                column: "GrupaProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_Stavke_FakturaID",
                schema: "dbo",
                table: "Stavke",
                column: "FakturaID");

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
                name: "Errors",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Lageri",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Stavke",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Students",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Fakture",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Proizvodi",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Klijenti",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GrupaProizvoda",
                schema: "dbo");
        }
    }
}
