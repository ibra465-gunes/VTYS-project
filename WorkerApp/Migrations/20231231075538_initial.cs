using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkerApp.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calisanlar",
                columns: table => new
                {
                    ÇalışanNo = table.Column<int>(name: "Çalışan No", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ÇalışanAdı = table.Column<string>(name: "Çalışan Adı", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ÇalışanSoyadı = table.Column<string>(name: "Çalışan Soyadı", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TamamlananGörevSayısı = table.Column<int>(name: "Tamamlanan Görev Sayısı", type: "int", nullable: true),
                    GecikenGörevSayısı = table.Column<int>(name: "Geciken Görev Sayısı", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calisanlar", x => x.ÇalışanNo);
                });

            migrationBuilder.CreateTable(
                name: "Proje",
                columns: table => new
                {
                    ProjeNo = table.Column<int>(name: "Proje No", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjeAdı = table.Column<string>(name: "Proje Adı", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BaşlangıçTarihi = table.Column<DateTime>(name: "Başlangıç Tarihi", type: "datetime2", nullable: false),
                    BitişTarihi = table.Column<DateTime>(name: "Bitiş Tarihi", type: "datetime2", nullable: false),
                    GecikmeMiktarı = table.Column<int>(name: "Gecikme Miktarı", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proje", x => x.ProjeNo);
                });

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

            migrationBuilder.CreateTable(
                name: "Gorevler",
                columns: table => new
                {
                    GörevNo = table.Column<int>(name: "Görev No", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GörevAdı = table.Column<string>(name: "Görev Adı", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BaşlangıçTarihi = table.Column<DateTime>(name: "Başlangıç Tarihi", type: "datetime2", nullable: false),
                    BitişTarihi = table.Column<DateTime>(name: "Bitiş Tarihi", type: "datetime2", nullable: false),
                    AdamGünDeğeri = table.Column<int>(name: "Adam Gün Değeri", type: "int", nullable: false),
                    Durum = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProjeNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorevler", x => x.GörevNo);
                    table.ForeignKey(
                        name: "FK_Gorevler_Proje_ProjeNo",
                        column: x => x.ProjeNo,
                        principalTable: "Proje",
                        principalColumn: "Proje No",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalisanProje_ProjelerProjeNo",
                table: "CalisanProje",
                column: "ProjelerProjeNo");

            migrationBuilder.CreateIndex(
                name: "IX_Gorevler_ProjeNo",
                table: "Gorevler",
                column: "ProjeNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalisanProje");

            migrationBuilder.DropTable(
                name: "Gorevler");

            migrationBuilder.DropTable(
                name: "Calisanlar");

            migrationBuilder.DropTable(
                name: "Proje");
        }
    }
}
