using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkerApp.Migrations
{
    /// <inheritdoc />
    public partial class CalısanNo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Çalışan No",
                table: "Gorevler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Çalışan No",
                table: "Gorevler");
        }
    }
}
