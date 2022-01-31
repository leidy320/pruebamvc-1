using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pruebamvc_1.Migrations.Trabajador
{
    public partial class Trabajador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trabajador",
                columns: table => new
                {
                    idtrabajador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoidentificacion = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    identificacion = table.Column<int>(nullable: false),
                    pr_nombre = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    seg_nombre = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    pr_apellido = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    seg_apellido = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    fecha_nacimiento = table.Column<DateTime>(nullable: false),
                    edad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajador", x => x.idtrabajador);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trabajador");
        }
    }
}
