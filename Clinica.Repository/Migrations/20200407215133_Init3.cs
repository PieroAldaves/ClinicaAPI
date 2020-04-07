using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Repository.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_horarios_seguros_SeguroId",
                table: "horarios");

            migrationBuilder.DropIndex(
                name: "IX_horarios_SeguroId",
                table: "horarios");

            migrationBuilder.DropColumn(
                name: "dia",
                table: "reservas");

            migrationBuilder.DropColumn(
                name: "SeguroId",
                table: "horarios");

            migrationBuilder.AddColumn<float>(
                name: "latitud",
                table: "sedes",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "longitud",
                table: "sedes",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<string>(
                name: "dni",
                table: "pacientes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "dni",
                table: "medicos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "latitud",
                table: "sedes");

            migrationBuilder.DropColumn(
                name: "longitud",
                table: "sedes");

            migrationBuilder.DropColumn(
                name: "dni",
                table: "medicos");

            migrationBuilder.AddColumn<string>(
                name: "dia",
                table: "reservas",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "dni",
                table: "pacientes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeguroId",
                table: "horarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_horarios_SeguroId",
                table: "horarios",
                column: "SeguroId");

            migrationBuilder.AddForeignKey(
                name: "FK_horarios_seguros_SeguroId",
                table: "horarios",
                column: "SeguroId",
                principalTable: "seguros",
                principalColumn: "SeguroId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
