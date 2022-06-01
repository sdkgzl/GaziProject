using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GaziProject.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BolumAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Derss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DersAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kredisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciNo = table.Column<int>(type: "int", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BolumId = table.Column<int>(type: "int", nullable: false),
                    BolumKoduId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ortalama = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Bolums_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciDerss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciNo = table.Column<int>(type: "int", nullable: false),
                    DersKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KacKezAldi = table.Column<int>(type: "int", nullable: false),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    VizeNotu = table.Column<double>(type: "float", nullable: false),
                    FinalNotu = table.Column<double>(type: "float", nullable: false),
                    Sonuc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciDerss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgrenciDerss_Derss_DersId",
                        column: x => x.DersId,
                        principalTable: "Derss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciDerss_Ogrencis_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrencis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDerss_DersId",
                table: "OgrenciDerss",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDerss_OgrenciId",
                table: "OgrenciDerss",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_BolumId",
                table: "Ogrencis",
                column: "BolumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgrenciDerss");

            migrationBuilder.DropTable(
                name: "Derss");

            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Bolums");
        }
    }
}
