using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Repository.Migrations
{
    public partial class Init12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_horarios_medicoespecialidades_MedicoEspecialidadId",
                table: "horarios");

            migrationBuilder.DropColumn(
                name: "MedicoEspecilidadId",
                table: "horarios");

            migrationBuilder.AlterColumn<int>(
                name: "MedicoEspecialidadId",
                table: "horarios",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_horarios_medicoespecialidades_MedicoEspecialidadId",
                table: "horarios",
                column: "MedicoEspecialidadId",
                principalTable: "medicoespecialidades",
                principalColumn: "MedicoEspecialidadId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_horarios_medicoespecialidades_MedicoEspecialidadId",
                table: "horarios");

            migrationBuilder.AlterColumn<int>(
                name: "MedicoEspecialidadId",
                table: "horarios",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "MedicoEspecilidadId",
                table: "horarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_horarios_medicoespecialidades_MedicoEspecialidadId",
                table: "horarios",
                column: "MedicoEspecialidadId",
                principalTable: "medicoespecialidades",
                principalColumn: "MedicoEspecialidadId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
