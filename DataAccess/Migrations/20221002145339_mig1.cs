using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ayakkabilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Model = table.Column<string>(type: "text", nullable: false),
                    MarkaId = table.Column<int>(type: "integer", nullable: false),
                    Numara = table.Column<byte>(type: "smallint", nullable: false),
                    ErkekMi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ayakkabilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Markalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Adi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Renkler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Adi = table.Column<string>(type: "text", nullable: false),
                    AyakkabiId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renkler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Renkler_Ayakkabilar_AyakkabiId",
                        column: x => x.AyakkabiId,
                        principalTable: "Ayakkabilar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Renkler_AyakkabiId",
                table: "Renkler",
                column: "AyakkabiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Markalar");

            migrationBuilder.DropTable(
                name: "Renkler");

            migrationBuilder.DropTable(
                name: "Ayakkabilar");
        }
    }
}
