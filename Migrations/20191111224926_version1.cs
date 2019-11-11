using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace relatorio.Migrations
{
    public partial class version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroGrupo = table.Column<int>(nullable: false),
                    Responsavel = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publicadores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 80, nullable: true),
                    GrupoId = table.Column<int>(nullable: false),
                    Sexo = table.Column<string>(nullable: true),
                    PublicadorBatizado = table.Column<bool>(nullable: false),
                    Anciao = table.Column<bool>(nullable: false),
                    ServoMinisterial = table.Column<bool>(nullable: false),
                    PioneiroRegular = table.Column<bool>(nullable: false),
                    PioneiroAuxiliar = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publicadores_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Publicadores_GrupoId",
                table: "Publicadores",
                column: "GrupoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Publicadores");

            migrationBuilder.DropTable(
                name: "Grupos");
        }
    }
}
