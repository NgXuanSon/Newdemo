using Microsoft.EntityFrameworkCore.Migrations;

namespace Netmo.Migrations
{
    public partial class Create_Table_Netdemo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Netdemos",
                columns: table => new
                {
                    NetdemoID = table.Column<string>(type: "TEXT", nullable: false),
                    NetdemoName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Netdemos", x => x.NetdemoID);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PesonID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    StudenID = table.Column<int>(type: "INTEGER", nullable: true),
                    University = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PesonID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Netdemos");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
