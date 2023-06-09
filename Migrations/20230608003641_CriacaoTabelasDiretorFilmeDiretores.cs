using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoFilmesApi.Migrations
{
    public partial class CriacaoTabelasDiretorFilmeDiretores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diretores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diretores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmeDiretores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFilme = table.Column<int>(type: "int", nullable: false),
                    IdDiretor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmeDiretores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmeDiretores_Diretores_IdDiretor",
                        column: x => x.IdDiretor,
                        principalTable: "Diretores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmeDiretores_Filmes_IdFilme",
                        column: x => x.IdFilme,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmeDiretores_IdDiretor",
                table: "FilmeDiretores",
                column: "IdDiretor");

            migrationBuilder.CreateIndex(
                name: "IX_FilmeDiretores_IdFilme",
                table: "FilmeDiretores",
                column: "IdFilme");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmeDiretores");

            migrationBuilder.DropTable(
                name: "Diretores");
        }
    }
}
