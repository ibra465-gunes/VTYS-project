using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkerApp.Migrations
{
    /// <inheritdoc />
    public partial class GorevProjeNo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gorevler_Proje_ProjeNo",
                table: "Gorevler");

            migrationBuilder.RenameColumn(
                name: "ProjeNo",
                table: "Gorevler",
                newName: "Proje No");

            migrationBuilder.RenameIndex(
                name: "IX_Gorevler_ProjeNo",
                table: "Gorevler",
                newName: "IX_Gorevler_Proje No");

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevler_Proje_Proje No",
                table: "Gorevler",
                column: "Proje No",
                principalTable: "Proje",
                principalColumn: "Proje No",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gorevler_Proje_Proje No",
                table: "Gorevler");

            migrationBuilder.RenameColumn(
                name: "Proje No",
                table: "Gorevler",
                newName: "ProjeNo");

            migrationBuilder.RenameIndex(
                name: "IX_Gorevler_Proje No",
                table: "Gorevler",
                newName: "IX_Gorevler_ProjeNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevler_Proje_ProjeNo",
                table: "Gorevler",
                column: "ProjeNo",
                principalTable: "Proje",
                principalColumn: "Proje No",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
