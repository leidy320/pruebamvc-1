using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pruebamvc_1.Migrations.Contrato
{
    public partial class Contrato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    idcontrato = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_entidad = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    num_contrato = table.Column<int>(nullable: false),
                    trab_vinculado = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    fecha_inicio = table.Column<DateTime>(nullable: false),
                    fecha_final = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.idcontrato);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contrato");
        }
    }
}
