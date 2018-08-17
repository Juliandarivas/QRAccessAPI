using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QRA.Migrations.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "QRA");

            migrationBuilder.CreateTable(
                name: "Cuenta",
                schema: "QRA",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(nullable: false),
                    NombreUsuario = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Clave = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Estado = table.Column<byte>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => new { x.Id, x.IdUsuario })
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "TipoIdentificacion",
                schema: "QRA",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoIdentificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "QRA",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTipoIdentificacion = table.Column<int>(nullable: false),
                    Identificacion = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Apellidos = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    Nombres = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Direccion = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Movil = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Telefono = table.Column<string>(type: "VARCHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuenta",
                schema: "QRA");

            migrationBuilder.DropTable(
                name: "TipoIdentificacion",
                schema: "QRA");

            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "QRA");
        }
    }
}
