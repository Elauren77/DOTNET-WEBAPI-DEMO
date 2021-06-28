using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class TeachersCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeachersInfo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    teaPref = table.Column<string>(type: "TEXT", nullable: true),
                    teaFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    teaLastName = table.Column<string>(type: "TEXT", nullable: true),
                    teaSubject = table.Column<int>(type: "INTEGER", nullable: false),
                    teaAge = table.Column<int>(type: "INTEGER", nullable: false),
                    teaOptionalLang = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachersInfo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TeachersInfo",
                columns: new[] { "Id", "teaAge", "teaFirstName", "teaLastName", "teaOptionalLang", "teaPref", "teaSubject" },
                values: new object[] { 1L, 11, "Amelia", "Petter", "French", "Ms.", 6 });

            migrationBuilder.InsertData(
                table: "TeachersInfo",
                columns: new[] { "Id", "teaAge", "teaFirstName", "teaLastName", "teaOptionalLang", "teaPref", "teaSubject" },
                values: new object[] { 2L, 12, "Richard", "Grey", "Spanish", "Mr.", 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeachersInfo");
        }
    }
}
