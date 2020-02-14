using Microsoft.EntityFrameworkCore.Migrations;

namespace NotesOfOrder.Data.Migrations
{
    public partial class ExampleEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExampleEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExampleEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExampleSubEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExampleEntityId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExampleSubEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExampleSubEntities_ExampleEntities_ExampleEntityId",
                        column: x => x.ExampleEntityId,
                        principalTable: "ExampleEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExampleSubEntities_ExampleEntityId",
                table: "ExampleSubEntities",
                column: "ExampleEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExampleSubEntities");

            migrationBuilder.DropTable(
                name: "ExampleEntities");
        }
    }
}
