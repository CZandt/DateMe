using Microsoft.EntityFrameworkCore.Migrations;

namespace DateMe.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    MajorID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MajorCode = table.Column<string>(nullable: true),
                    MajorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.MajorID);
                });

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
                    CreeperStalker = table.Column<bool>(nullable: false),
                    MajorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.ApplicationID);
                    table.ForeignKey(
                        name: "FK_responses_Majors_MajorID",
                        column: x => x.MajorID,
                        principalTable: "Majors",
                        principalColumn: "MajorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorID", "MajorCode", "MajorName" },
                values: new object[] { 1, null, "Information Systems" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorID", "MajorCode", "MajorName" },
                values: new object[] { 2, null, "Accounting" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorID", "MajorCode", "MajorName" },
                values: new object[] { 3, null, "Aerospace Engineering" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorID", "MajorCode", "MajorName" },
                values: new object[] { 4, null, "Undeclared" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationID", "Age", "CreeperStalker", "FirstName", "LastName", "MajorID", "Phone" },
                values: new object[] { 1, (byte)45, false, "Michael", "Scott", 1, "555-555-5555" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationID", "Age", "CreeperStalker", "FirstName", "LastName", "MajorID", "Phone" },
                values: new object[] { 2, (byte)20, false, "Cole", "Hardy", 2, "000-900-0000" });

            migrationBuilder.CreateIndex(
                name: "IX_responses_MajorID",
                table: "responses",
                column: "MajorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "Majors");
        }
    }
}
