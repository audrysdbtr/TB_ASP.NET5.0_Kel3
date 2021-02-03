using Microsoft.EntityFrameworkCore.Migrations;

namespace Warungcd.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NamaBarang = table.Column<string>(type: "TEXT", nullable: true),
                    Deskripsi = table.Column<string>(type: "TEXT", nullable: true),
                    UrlGambar = table.Column<string>(type: "TEXT", nullable: true),
                    Harga = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barang", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barang");
        }
    }
}
