using Microsoft.EntityFrameworkCore.Migrations;

namespace SaglikProje.Migrations
{
    public partial class Belirti_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Belirtis",
                columns: table => new
                {
                    BelirtiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Belirtiler = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Belirtis", x => x.BelirtiId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Belirtis");
        }
    }
}
