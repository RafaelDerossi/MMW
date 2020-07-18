using Microsoft.EntityFrameworkCore.Migrations;

namespace MMW.Infra.Persistencia.Migrations
{
    public partial class CNPJ14_e_IndexEstoque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Estoques_LojaId",
                table: "Estoques");

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Lojas",
                type: "varchar(14)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_LojaId_ProdutoId",
                table: "Estoques",
                columns: new[] { "LojaId", "ProdutoId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Estoques_LojaId_ProdutoId",
                table: "Estoques");

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Lojas",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(14)");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_LojaId",
                table: "Estoques",
                column: "LojaId");
        }
    }
}
