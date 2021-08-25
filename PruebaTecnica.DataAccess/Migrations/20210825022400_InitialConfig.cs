using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaTecnica.DataAccess.Migrations
{
    public partial class InitialConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asignatura",
                columns: table => new
                {
                    IdAsignatura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignatura", x => x.IdAsignatura);
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    IdEstudiante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.IdEstudiante);
                });

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    IdProfesor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.IdProfesor);
                });

            migrationBuilder.CreateTable(
                name: "Asignacion",
                columns: table => new
                {
                    IdAsignacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsignaturaId = table.Column<int>(type: "int", nullable: false),
                    EstudianteId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignacion", x => x.IdAsignacion);
                    table.ForeignKey(
                        name: "FK_Asignacion_Asignatura_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "Asignatura",
                        principalColumn: "IdAsignatura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asignacion_Estudiante_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiante",
                        principalColumn: "IdEstudiante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aula",
                columns: table => new
                {
                    IdAula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsignaturaId = table.Column<int>(type: "int", nullable: false),
                    ProfesorId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aula", x => x.IdAula);
                    table.ForeignKey(
                        name: "FK_Aula_Asignatura_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "Asignatura",
                        principalColumn: "IdAsignatura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aula_Profesor_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "Profesor",
                        principalColumn: "IdProfesor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asignacion_AsignaturaId",
                table: "Asignacion",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignacion_EstudianteId",
                table: "Asignacion",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Aula_AsignaturaId",
                table: "Aula",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Aula_ProfesorId",
                table: "Aula",
                column: "ProfesorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asignacion");

            migrationBuilder.DropTable(
                name: "Aula");

            migrationBuilder.DropTable(
                name: "Estudiante");

            migrationBuilder.DropTable(
                name: "Asignatura");

            migrationBuilder.DropTable(
                name: "Profesor");
        }
    }
}
