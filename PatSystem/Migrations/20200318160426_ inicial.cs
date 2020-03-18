using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PatSystem.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cbo",
                columns: table => new
                {
                    CodCboId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Desc = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cbo", x => x.CodCboId);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 40, nullable: false),
                    Nascimento = table.Column<DateTime>(nullable: false),
                    TlFixo = table.Column<int>(nullable: false),
                    TlMovel = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    AreaAtuacao = table.Column<string>(maxLength: 30, nullable: false),
                    EnsinoMedio = table.Column<string>(nullable: false),
                    Idade = table.Column<int>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
                    UF = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(maxLength: 40, nullable: false),
                    Rua = table.Column<string>(maxLength: 40, nullable: false),
                    Numero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    EmpresaId = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Segmento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.EmpresaId);
                });

            migrationBuilder.CreateTable(
                name: "Curriculo",
                columns: table => new
                {
                    CurriculoID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteID = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    CursoSuperiorSN = table.Column<string>(nullable: true),
                    CursoTecnicoSN = table.Column<string>(nullable: true),
                    IdiomaSN = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculo", x => x.CurriculoID);
                    table.ForeignKey(
                        name: "FK_Curriculo_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seguro",
                columns: table => new
                {
                    SeguroId = table.Column<double>(nullable: false),
                    CodSeguro = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: false),
                    CodCboid = table.Column<int>(nullable: false),
                    EmpresaId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguro", x => x.SeguroId);
                    table.ForeignKey(
                        name: "FK_Seguro_Cbo_CodCboid",
                        column: x => x.CodCboid,
                        principalTable: "Cbo",
                        principalColumn: "CodCboId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seguro_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CursoSuperior",
                columns: table => new
                {
                    CurriculoID = table.Column<int>(nullable: false),
                    CursoSuperiorId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Modalidade = table.Column<string>(nullable: true),
                    Instituicao = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoSuperior", x => new { x.CurriculoID, x.CursoSuperiorId });
                    table.ForeignKey(
                        name: "FK_CursoSuperior_Curriculo_CurriculoID",
                        column: x => x.CurriculoID,
                        principalTable: "Curriculo",
                        principalColumn: "CurriculoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CursoTecnico",
                columns: table => new
                {
                    CurriculoID = table.Column<int>(nullable: false),
                    CursoTecnicoId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Modalidade = table.Column<string>(nullable: true),
                    Instituicao = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoTecnico", x => new { x.CurriculoID, x.CursoTecnicoId });
                    table.ForeignKey(
                        name: "FK_CursoTecnico_Curriculo_CurriculoID",
                        column: x => x.CurriculoID,
                        principalTable: "Curriculo",
                        principalColumn: "CurriculoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiencia",
                columns: table => new
                {
                    ExperienciaId = table.Column<int>(nullable: false),
                    CurriculoID = table.Column<int>(nullable: false),
                    NomeEmpresa = table.Column<string>(nullable: true),
                    UltimoCargo = table.Column<string>(nullable: true),
                    Anos = table.Column<double>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencia", x => new { x.CurriculoID, x.ExperienciaId });
                    table.ForeignKey(
                        name: "FK_Experiencia_Curriculo_CurriculoID",
                        column: x => x.CurriculoID,
                        principalTable: "Curriculo",
                        principalColumn: "CurriculoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Idioma",
                columns: table => new
                {
                    IdiomaId = table.Column<int>(nullable: false),
                    CurriculoID = table.Column<int>(nullable: false),
                    Nome = table.Column<int>(nullable: false),
                    Instituicao = table.Column<string>(nullable: true),
                    NivelFluencia = table.Column<int>(nullable: false),
                    AnosCursados = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idioma", x => new { x.CurriculoID, x.IdiomaId });
                    table.ForeignKey(
                        name: "FK_Idioma_Curriculo_CurriculoID",
                        column: x => x.CurriculoID,
                        principalTable: "Curriculo",
                        principalColumn: "CurriculoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curriculo_ClienteID",
                table: "Curriculo",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Seguro_CodCboid",
                table: "Seguro",
                column: "CodCboid");

            migrationBuilder.CreateIndex(
                name: "IX_Seguro_EmpresaId",
                table: "Seguro",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CursoSuperior");

            migrationBuilder.DropTable(
                name: "CursoTecnico");

            migrationBuilder.DropTable(
                name: "Experiencia");

            migrationBuilder.DropTable(
                name: "Idioma");

            migrationBuilder.DropTable(
                name: "Seguro");

            migrationBuilder.DropTable(
                name: "Curriculo");

            migrationBuilder.DropTable(
                name: "Cbo");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
