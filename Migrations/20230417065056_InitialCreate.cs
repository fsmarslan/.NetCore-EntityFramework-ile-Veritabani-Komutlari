using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entity.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "egitmenler",
                columns: table => new
                {
                    egitmenId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    egitmenAd = table.Column<string>(type: "TEXT", nullable: false),
                    egitmenSoyad = table.Column<string>(type: "TEXT", nullable: false),
                    egitmenYas = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_egitmenler", x => x.egitmenId);
                });

            migrationBuilder.CreateTable(
                name: "kurslar",
                columns: table => new
                {
                    kursId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    kursAd = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kurslar", x => x.kursId);
                });

            migrationBuilder.CreateTable(
                name: "ogrenciler",
                columns: table => new
                {
                    ogrenciId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ogrenciAd = table.Column<string>(type: "TEXT", nullable: false),
                    ogrenciSoyad = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ogrenciler", x => x.ogrenciId);
                });

            migrationBuilder.CreateTable(
                name: "personeller",
                columns: table => new
                {
                    perId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    perAd = table.Column<string>(type: "TEXT", nullable: false),
                    perSoyad = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personeller", x => x.perId);
                });

            migrationBuilder.CreateTable(
                name: "siniflar",
                columns: table => new
                {
                    sinifId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    sinifNo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siniflar", x => x.sinifId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "egitmenler");

            migrationBuilder.DropTable(
                name: "kurslar");

            migrationBuilder.DropTable(
                name: "ogrenciler");

            migrationBuilder.DropTable(
                name: "personeller");

            migrationBuilder.DropTable(
                name: "siniflar");
        }
    }
}
