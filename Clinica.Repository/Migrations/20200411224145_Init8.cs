using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Repository.Migrations
{
    public partial class Init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_medicoespecialidades_horarios_HorarioId",
                table: "medicoespecialidades");

            migrationBuilder.DropIndex(
                name: "IX_medicoespecialidades_HorarioId",
                table: "medicoespecialidades");

            migrationBuilder.DropColumn(
                name: "HorarioId",
                table: "medicoespecialidades");

            migrationBuilder.AddColumn<int>(
                name: "MedicoEspecialidadId",
                table: "horarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedicoEspecilidadId",
                table: "horarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_horarios_MedicoEspecialidadId",
                table: "horarios",
                column: "MedicoEspecialidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_horarios_medicoespecialidades_MedicoEspecialidadId",
                table: "horarios",
                column: "MedicoEspecialidadId",
                principalTable: "medicoespecialidades",
                principalColumn: "MedicoEspecialidadId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_horarios_medicoespecialidades_MedicoEspecialidadId",
                table: "horarios");

            migrationBuilder.DropIndex(
                name: "IX_horarios_MedicoEspecialidadId",
                table: "horarios");

            migrationBuilder.DropColumn(
                name: "MedicoEspecialidadId",
                table: "horarios");

            migrationBuilder.DropColumn(
                name: "MedicoEspecilidadId",
                table: "horarios");

            migrationBuilder.AddColumn<int>(
                name: "HorarioId",
                table: "medicoespecialidades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_medicoespecialidades_HorarioId",
                table: "medicoespecialidades",
                column: "HorarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_medicoespecialidades_horarios_HorarioId",
                table: "medicoespecialidades",
                column: "HorarioId",
                principalTable: "horarios",
                principalColumn: "HorarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
