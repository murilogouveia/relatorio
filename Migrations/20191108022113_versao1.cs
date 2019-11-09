using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace relatorio.Migrations
{
    public partial class versao1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataFimAtividade",
                table: "Publicadores");

            migrationBuilder.DropColumn(
                name: "DataInicioAtividade",
                table: "Publicadores");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Grupos");

            migrationBuilder.AddColumn<bool>(
                name: "PublicadorBatizado",
                table: "Publicadores",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Responsavel",
                table: "Grupos",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AddColumn<int>(
                name: "NumeroGrupo",
                table: "Grupos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicadorBatizado",
                table: "Publicadores");

            migrationBuilder.DropColumn(
                name: "NumeroGrupo",
                table: "Grupos");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFimAtividade",
                table: "Publicadores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicioAtividade",
                table: "Publicadores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Responsavel",
                table: "Grupos",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Grupos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
