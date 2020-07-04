using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MMW.Infra.Persistencia.Migrations
{
    public partial class Date_DateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Produtos",
                type: "DateTime",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "Produtos",
                type: "DateTime",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValueSql: "GetDate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Produtos",
                type: "Date",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "Produtos",
                type: "Date",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValueSql: "GetDate()");
        }
    }
}
