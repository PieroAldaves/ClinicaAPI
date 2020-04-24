using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Repository.Migrations
{
    public partial class Init17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genger",
                table: "medicos",
                newName: "Gender");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "medicos",
                newName: "Genger");
        }
    }
}
