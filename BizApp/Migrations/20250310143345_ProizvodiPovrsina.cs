using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BizApp.Migrations
{
    /// <inheritdoc />
    public partial class ProizvodiPovrsina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
