using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV.Migrations
{
    public partial class CV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parola = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "panelAbouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanıtım = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NelerYapıyorumAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NelerYapıyorumIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_panelAbouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "panelEducations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OkulAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OkulYıl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OkulAlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OkulIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_panelEducations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "panelExperiances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeneyimAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeneyimYıl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeneyimAlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeneyimIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_panelExperiances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "panelProfils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilResmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeslekAlanı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Konum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KonumAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Github = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_panelProfils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "panelProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogAdres = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_panelProjects", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "panelAbouts");

            migrationBuilder.DropTable(
                name: "panelEducations");

            migrationBuilder.DropTable(
                name: "panelExperiances");

            migrationBuilder.DropTable(
                name: "panelProfils");

            migrationBuilder.DropTable(
                name: "panelProjects");
        }
    }
}
