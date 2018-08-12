using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QRA.Migrations.Migrations
{
    public partial class InitialMigration : Migration
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
                    NombreUsuario = table.Column<string>(nullable: true),
                    Clave = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.Id);
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
                    Identificacion = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Nombres = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    CorreoElectronico = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Movil = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true)
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
