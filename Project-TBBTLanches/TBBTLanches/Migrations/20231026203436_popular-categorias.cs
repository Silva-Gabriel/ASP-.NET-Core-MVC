using Microsoft.EntityFrameworkCore.Migrations;
using TBBTLanches.Models;

#nullable disable

namespace TBBTLanches.Migrations
{
    /// <inheritdoc />
    public partial class popularcategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO Categorias(Nome, Descricao) VALUES ('Normal', 'Lanche feito com ingredientes normais')"
                );
            migrationBuilder.Sql(
                "INSERT INTO Categorias(Nome, Descricao) VALUES ('Natural', 'Lanche feito com ingredientes naturais')"
                );
            migrationBuilder.Sql(
                "INSERT INTO Categorias(Nome, Descricao) VALUES ('Natural+', 'Lanche feito com ingredientes naturais e com acompanhamento')"
                );
            migrationBuilder.Sql(
                "INSERT INTO Categorias(Nome, Descricao) VALUES ('Normal+', 'Lanche feito com ingredientes normais e com acompanhamento')"
                );
            migrationBuilder.Sql(
                "INSERT INTO Categorias(Nome, Descricao) VALUES ('Grelhado', 'Lanche feito com ingredientes grelhados')"
                );
            migrationBuilder.Sql(
                "INSERT INTO Categorias(Nome, Descricao) VALUES ('Grelhado+', 'Lanche feito com ingredientes grelhados e com acompanhamento')"
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
