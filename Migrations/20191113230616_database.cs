using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace relatorio.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroGrupo = table.Column<int>(nullable: false),
                    Responsavel = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publicador",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    GrupoId = table.Column<int>(nullable: false),
                    Sexo = table.Column<string>(type: "varchar(5)", nullable: true),
                    PublicadorBatizado = table.Column<bool>(nullable: false),
                    Anciao = table.Column<bool>(nullable: false),
                    ServoMinisterial = table.Column<bool>(nullable: false),
                    PioneiroRegular = table.Column<bool>(nullable: false),
                    PioneiroAuxiliar = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publicador_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Publicador_GrupoId",
                table: "Publicador",
                column: "GrupoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Publicador");

            migrationBuilder.DropTable(
                name: "Grupo");
        }
    }
}
