using Microsoft.EntityFrameworkCore.Migrations;

namespace NotesOfOrder.Data.Migrations
{
    public partial class Notes1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MapCoordinatesX = table.Column<int>(nullable: false),
                    MapCoordinatesY = table.Column<int>(nullable: false),
                    StartRatId = table.Column<int>(nullable: false),
                    StartSeasonId = table.Column<int>(nullable: false),
                    StartSunId = table.Column<int>(nullable: false),
                    EndRatId = table.Column<int>(nullable: false),
                    EndSeasonId = table.Column<int>(nullable: false),
                    EndSunId = table.Column<int>(nullable: false),
                    CharacterId = table.Column<int>(nullable: false),
                    StorageLocale = table.Column<string>(nullable: true),
                    CurrencyGold = table.Column<int>(nullable: false),
                    NoteText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
