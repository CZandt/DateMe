using Microsoft.EntityFrameworkCore.Migrations;

namespace DateMe.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<byte>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Major = table.Column<string>(nullable: true),
                    CreeperStalker = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.ApplicationID);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationID", "Age", "CreeperStalker", "FirstName", "LastName", "Major", "Phone" },
                values: new object[] { 1, (byte)45, false, "Michael", "Scott", "Sales", "555-555-5555" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationID", "Age", "CreeperStalker", "FirstName", "LastName", "Major", "Phone" },
                values: new object[] { 2, (byte)20, false, "Cole", "Hardy", "Information Systems", "000-900-0000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
