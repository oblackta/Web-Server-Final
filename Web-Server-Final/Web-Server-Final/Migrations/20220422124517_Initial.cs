using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_Server_Final.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportName = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(maxLength: 200, nullable: false),
                    City = table.Column<string>(nullable: true),
                    SportId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportId", "SportName" },
                values: new object[,]
                {
                    { 1, "Basketball" },
                    { 2, "Football" },
                    { 3, "Soccer" },
                    { 4, "Baseball" },
                    { 5, "Rugby" },
                    { 6, "Tennis" },
                    { 7, "Lacrosse" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "City", "SportId", "TeamName" },
                values: new object[,]
                {
                    { 1, "Cincinnati", 2, "Bengals" },
                    { 2, "Cincinnati", 4, "Reds" },
                    { 3, "Miami", 1, "Heat" },
                    { 4, "Sacremento", 1, "Kings" },
                    { 5, "Atlanta", 4, "Braves" },
                    { 6, "Indiana", 2, "Colts" },
                    { 7, "Cincinnati", 3, "FC" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sports");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
