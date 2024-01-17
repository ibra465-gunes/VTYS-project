using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkerApp.Migrations
{
    /// <inheritdoc />
    public partial class ProjeCalisan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalisanProje");

            migrationBuilder.CreateTable(
                name: "ProjeCalisan",
                columns: table => new
                {
                    ProjeNo = table.Column<int>(type: "int", nullable: false),
                    CalisanNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjeCalisan", x => new { x.ProjeNo, x.CalisanNo });
                    table.ForeignKey(
                        name: "FK_ProjeCalisan_Calisanlar_CalisanNo",
                        column: x => x.CalisanNo,
                        principalTable: "Calisanlar",
                        principalColumn: "Çalışan No",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjeCalisan_Proje_ProjeNo",
                        column: x => x.ProjeNo,
                        principalTable: "Proje",
                        principalColumn: "Proje No",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjeCalisan_CalisanNo",
                table: "ProjeCalisan",
                column: "CalisanNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjeCalisan");

            migrationBuilder.CreateTable(
                name: "CalisanProje",
                columns: table => new
                {
                    CalisanlarCalisanNo = table.Column<int>(type: "int", nullable: false),
                    ProjelerProjeNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalisanProje", x => new { x.CalisanlarCalisanNo, x.ProjelerProjeNo });
                    table.ForeignKey(
                        name: "FK_CalisanProje_Calisanlar_CalisanlarCalisanNo",
                        column: x => x.CalisanlarCalisanNo,
                        principalTable: "Calisanlar",
                        principalColumn: "Çalışan No",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalisanProje_Proje_ProjelerProjeNo",
                        column: x => x.ProjelerProjeNo,
                        principalTable: "Proje",
                        principalColumn: "Proje No",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalisanProje_ProjelerProjeNo",
                table: "CalisanProje",
                column: "ProjelerProjeNo");
        }
    }
}
