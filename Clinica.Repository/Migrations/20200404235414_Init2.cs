using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Clinica.Repository.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Publish",
                table: "roles",
                newName: "RolState");

            migrationBuilder.CreateTable(
                name: "dias",
                columns: table => new
                {
                    DiaId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DiaName = table.Column<string>(nullable: true),
                    DiaDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dias", x => x.DiaId);
                });

            migrationBuilder.CreateTable(
                name: "especialidades",
                columns: table => new
                {
                    EspecialidadId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EspecialidadName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_especialidades", x => x.EspecialidadId);
                });

            migrationBuilder.CreateTable(
                name: "medicos",
                columns: table => new
                {
                    MedicoId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    LastName_Maternal = table.Column<string>(nullable: true),
                    LastName_Paternal = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    Genger = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Distrito = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Imagen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicos", x => x.MedicoId);
                    table.ForeignKey(
                        name: "FK_medicos_usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    LastName_Maternal = table.Column<string>(nullable: true),
                    LastName_Paternal = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    dni = table.Column<int>(nullable: false),
                    Age = table.Column<string>(nullable: true),
                    Genger = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Distrito = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    BornDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacientes", x => x.PacienteId);
                    table.ForeignKey(
                        name: "FK_pacientes_usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sedes",
                columns: table => new
                {
                    SedeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    SedeName = table.Column<string>(nullable: true),
                    SedeAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sedes", x => x.SedeId);
                });

            migrationBuilder.CreateTable(
                name: "seguros",
                columns: table => new
                {
                    SeguroId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    SeguroName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seguros", x => x.SeguroId);
                });

            migrationBuilder.CreateTable(
                name: "horarios",
                columns: table => new
                {
                    HorarioId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DayName = table.Column<string>(nullable: true),
                    HorarioFecha = table.Column<DateTime>(nullable: false),
                    FechaHoraInicio = table.Column<DateTime>(nullable: false),
                    FechaHoraFin = table.Column<DateTime>(nullable: false),
                    SedeId = table.Column<int>(nullable: false),
                    SeguroId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_horarios", x => x.HorarioId);
                    table.ForeignKey(
                        name: "FK_horarios_sedes_SedeId",
                        column: x => x.SedeId,
                        principalTable: "sedes",
                        principalColumn: "SedeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_horarios_seguros_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "seguros",
                        principalColumn: "SeguroId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "horarioseguros",
                columns: table => new
                {
                    HorarioSeguroId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    HorarioId = table.Column<int>(nullable: false),
                    SeguroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_horarioseguros", x => x.HorarioSeguroId);
                    table.ForeignKey(
                        name: "FK_horarioseguros_horarios_HorarioId",
                        column: x => x.HorarioId,
                        principalTable: "horarios",
                        principalColumn: "HorarioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_horarioseguros_seguros_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "seguros",
                        principalColumn: "SeguroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicoespecialidades",
                columns: table => new
                {
                    MedicoEspecialidadId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    MedicoId = table.Column<int>(nullable: false),
                    EspecialidadId = table.Column<int>(nullable: false),
                    HorarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicoespecialidades", x => x.MedicoEspecialidadId);
                    table.ForeignKey(
                        name: "FK_medicoespecialidades_especialidades_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "especialidades",
                        principalColumn: "EspecialidadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicoespecialidades_horarios_HorarioId",
                        column: x => x.HorarioId,
                        principalTable: "horarios",
                        principalColumn: "HorarioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicoespecialidades_medicos_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "medicos",
                        principalColumn: "MedicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "turnos",
                columns: table => new
                {
                    TurnoId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Constante = table.Column<int>(nullable: false),
                    FechaHoraInicio = table.Column<DateTime>(nullable: false),
                    FechaHoraFin = table.Column<DateTime>(nullable: false),
                    Disponible = table.Column<bool>(nullable: false),
                    HorarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turnos", x => x.TurnoId);
                    table.ForeignKey(
                        name: "FK_turnos_horarios_HorarioId",
                        column: x => x.HorarioId,
                        principalTable: "horarios",
                        principalColumn: "HorarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservas",
                columns: table => new
                {
                    ReservaId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PacienteId = table.Column<int>(nullable: false),
                    MedicoId = table.Column<int>(nullable: false),
                    EspecialidadId = table.Column<int>(nullable: false),
                    HorarioId = table.Column<int>(nullable: false),
                    TurnoId = table.Column<int>(nullable: false),
                    SeguroId = table.Column<int>(nullable: false),
                    SedeId = table.Column<int>(nullable: false),
                    dia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservas", x => x.ReservaId);
                    table.ForeignKey(
                        name: "FK_reservas_especialidades_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "especialidades",
                        principalColumn: "EspecialidadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservas_horarios_HorarioId",
                        column: x => x.HorarioId,
                        principalTable: "horarios",
                        principalColumn: "HorarioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservas_medicos_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "medicos",
                        principalColumn: "MedicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservas_pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "pacientes",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservas_sedes_SedeId",
                        column: x => x.SedeId,
                        principalTable: "sedes",
                        principalColumn: "SedeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservas_seguros_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "seguros",
                        principalColumn: "SeguroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservas_turnos_TurnoId",
                        column: x => x.TurnoId,
                        principalTable: "turnos",
                        principalColumn: "TurnoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_horarios_SedeId",
                table: "horarios",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_horarios_SeguroId",
                table: "horarios",
                column: "SeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_horarioseguros_HorarioId",
                table: "horarioseguros",
                column: "HorarioId");

            migrationBuilder.CreateIndex(
                name: "IX_horarioseguros_SeguroId",
                table: "horarioseguros",
                column: "SeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_medicoespecialidades_EspecialidadId",
                table: "medicoespecialidades",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_medicoespecialidades_HorarioId",
                table: "medicoespecialidades",
                column: "HorarioId");

            migrationBuilder.CreateIndex(
                name: "IX_medicoespecialidades_MedicoId",
                table: "medicoespecialidades",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_medicos_UsuarioId",
                table: "medicos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_pacientes_UsuarioId",
                table: "pacientes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_EspecialidadId",
                table: "reservas",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_HorarioId",
                table: "reservas",
                column: "HorarioId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_MedicoId",
                table: "reservas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_PacienteId",
                table: "reservas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_SedeId",
                table: "reservas",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_SeguroId",
                table: "reservas",
                column: "SeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_TurnoId",
                table: "reservas",
                column: "TurnoId");

            migrationBuilder.CreateIndex(
                name: "IX_turnos_HorarioId",
                table: "turnos",
                column: "HorarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dias");

            migrationBuilder.DropTable(
                name: "horarioseguros");

            migrationBuilder.DropTable(
                name: "medicoespecialidades");

            migrationBuilder.DropTable(
                name: "reservas");

            migrationBuilder.DropTable(
                name: "especialidades");

            migrationBuilder.DropTable(
                name: "medicos");

            migrationBuilder.DropTable(
                name: "pacientes");

            migrationBuilder.DropTable(
                name: "turnos");

            migrationBuilder.DropTable(
                name: "horarios");

            migrationBuilder.DropTable(
                name: "sedes");

            migrationBuilder.DropTable(
                name: "seguros");

            migrationBuilder.RenameColumn(
                name: "RolState",
                table: "roles",
                newName: "Publish");
        }
    }
}
