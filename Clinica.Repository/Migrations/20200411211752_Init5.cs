using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Repository.Migrations
{
    public partial class Init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_medicos_usuarios_UsuarioId",
                table: "medicos");

            migrationBuilder.DropIndex(
                name: "IX_medicos_UsuarioId",
                table: "medicos");

            migrationBuilder.DropColumn(
                name: "RolState",
                table: "roles");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "medicos");

            migrationBuilder.AddColumn<bool>(
                name: "UsuarioState",
                table: "usuarios",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioState",
                table: "usuarios");

            migrationBuilder.AddColumn<bool>(
                name: "RolState",
                table: "roles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "medicos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_medicos_UsuarioId",
                table: "medicos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_medicos_usuarios_UsuarioId",
                table: "medicos",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
