using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GaziProject.Migrations
{
    public partial class changeOgrenciDers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DersKodu",
                table: "OgrenciDerss");

            migrationBuilder.DropColumn(
                name: "OgrenciNo",
                table: "OgrenciDerss");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DersKodu",
                table: "OgrenciDerss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OgrenciNo",
                table: "OgrenciDerss",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
