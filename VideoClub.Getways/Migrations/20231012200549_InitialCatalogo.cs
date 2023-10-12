using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace VideoClub.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCatalogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "actores",
                columns: table => new
                {
                    idactor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nombreactor = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actores", x => x.idactor);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    idcategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    categoria = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.idcategoria);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "generos",
                columns: table => new
                {
                    idgenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    genero = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_generos", x => x.idgenero);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "catalogo",
                columns: table => new
                {
                    idcatalogo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    poster = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    titulo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    idcategoria = table.Column<int>(type: "int", nullable: false),
                    resumen = table.Column<string>(type: "longtext", nullable: false),
                    temoradas = table.Column<int>(type: "int", nullable: true),
                    trailer = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catalogo", x => x.idcatalogo);
                    table.ForeignKey(
                        name: "FK_catalogo_categorias_idcategoria",
                        column: x => x.idcategoria,
                        principalTable: "categorias",
                        principalColumn: "idcategoria",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "generotrailer",
                columns: table => new
                {
                    IdCatalogo = table.Column<int>(type: "int", nullable: false),
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_generotrailer", x => new { x.IdCatalogo, x.IdGenero });
                    table.ForeignKey(
                        name: "FK_generotrailer_catalogo_IdCatalogo",
                        column: x => x.IdCatalogo,
                        principalTable: "catalogo",
                        principalColumn: "idcatalogo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_generotrailer_generos_IdGenero",
                        column: x => x.IdGenero,
                        principalTable: "generos",
                        principalColumn: "idgenero",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "reparto",
                columns: table => new
                {
                    idtrailer = table.Column<int>(type: "int", nullable: false),
                    idactor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reparto", x => new { x.idtrailer, x.idactor });
                    table.ForeignKey(
                        name: "FK_reparto_actores_idactor",
                        column: x => x.idactor,
                        principalTable: "actores",
                        principalColumn: "idactor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reparto_catalogo_idtrailer",
                        column: x => x.idtrailer,
                        principalTable: "catalogo",
                        principalColumn: "idcatalogo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_catalogo_idcategoria",
                table: "catalogo",
                column: "idcategoria");

            migrationBuilder.CreateIndex(
                name: "IX_generotrailer_IdGenero",
                table: "generotrailer",
                column: "IdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_reparto_idactor",
                table: "reparto",
                column: "idactor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "generotrailer");

            migrationBuilder.DropTable(
                name: "reparto");

            migrationBuilder.DropTable(
                name: "generos");

            migrationBuilder.DropTable(
                name: "actores");

            migrationBuilder.DropTable(
                name: "catalogo");

            migrationBuilder.DropTable(
                name: "categorias");
        }
    }
}
