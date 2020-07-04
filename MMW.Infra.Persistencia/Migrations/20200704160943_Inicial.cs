using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MMW.Infra.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(255)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "varchar(255)", nullable: true),
                    Fantasia = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lojas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(255)", nullable: true),
                    RazaoSocal = table.Column<string>(type: "varchar(255)", nullable: true),
                    Fantasia = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lojas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInclusao = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    DataAlteracao = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    Descricao = table.Column<string>(type: "varchar(255)", nullable: true),
                    PrcUnit = table.Column<decimal>(nullable: false),
                    Inativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    LojaId = table.Column<int>(nullable: false),
                    FornecedorId = table.Column<int>(nullable: false),
                    DataEmissaoNota = table.Column<DateTime>(nullable: false),
                    NumeroNota = table.Column<string>(type: "varchar(255)", nullable: true),
                    Baixada = table.Column<bool>(nullable: false),
                    DataBaixa = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entradas_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entradas_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    LojaId = table.Column<int>(nullable: false),
                    EmEstoque = table.Column<decimal>(nullable: false),
                    localizacao = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estoques_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estoques_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItensEntrada",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    EntradaId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    CodIntForn = table.Column<string>(type: "varchar(255)", nullable: true),
                    Item = table.Column<int>(nullable: false),
                    Qtd = table.Column<decimal>(nullable: false),
                    PrcUnit = table.Column<decimal>(nullable: false),
                    Desconto = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    Seguro = table.Column<decimal>(nullable: false),
                    Frete = table.Column<decimal>(nullable: false),
                    OutrasDespesas = table.Column<decimal>(nullable: false),
                    PrcCustoCalc = table.Column<decimal>(nullable: false),
                    Markup = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensEntrada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensEntrada_Entradas_EntradaId",
                        column: x => x.EntradaId,
                        principalTable: "Entradas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItensEntrada_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_FornecedorId",
                table: "Entradas",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_LojaId",
                table: "Entradas",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_LojaId",
                table: "Estoques",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_ProdutoId",
                table: "Estoques",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensEntrada_EntradaId",
                table: "ItensEntrada",
                column: "EntradaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensEntrada_ProdutoId",
                table: "ItensEntrada",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "ItensEntrada");

            migrationBuilder.DropTable(
                name: "Entradas");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "Lojas");
        }
    }
}
