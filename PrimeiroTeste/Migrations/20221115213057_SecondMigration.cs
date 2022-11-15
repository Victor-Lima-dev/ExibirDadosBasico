using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiroTeste.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Projetos(Titulo, Descricao,)" + 
                "VALUES('Funcionamento Maquinas Marilan', 'Tenta simular como funciona as maquinas da Marilan, considerando falhas que comprometem a produção')");
            
            migrationBuilder.Sql("INSERT INTO Projetos(Titulo, Descricao,)" + 
                "VALUES('Aplicativos de Notas', 'Pequeno CRUD para notas')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Projetos");
        }
    }
}
