using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BizApp.Migrations
{
    /// <inheritdoc />
    public partial class LagerUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Lageri_ProizvodID",
                schema: "dbo",
                table: "Lageri");

            migrationBuilder.CreateIndex(
                name: "IX_Lageri_ProizvodID",
                schema: "dbo",
                table: "Lageri",
                column: "ProizvodID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Lageri_ProizvodID",
                schema: "dbo",
                table: "Lageri");

            migrationBuilder.CreateIndex(
                name: "IX_Lageri_ProizvodID",
                schema: "dbo",
                table: "Lageri",
                column: "ProizvodID");
        }
    }
}
