using Microsoft.EntityFrameworkCore.Migrations;

namespace tipo.Migrations
{
    public partial class total : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AcudienteID",
                table: "Estudiante",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_AcudienteID",
                table: "Estudiante",
                column: "AcudienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiante_Acudiente_AcudienteID",
                table: "Estudiante",
                column: "AcudienteID",
                principalTable: "Acudiente",
                principalColumn: "AcudienteID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiante_Acudiente_AcudienteID",
                table: "Estudiante");

            migrationBuilder.DropIndex(
                name: "IX_Estudiante_AcudienteID",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "AcudienteID",
                table: "Estudiante");
        }
    }
}
