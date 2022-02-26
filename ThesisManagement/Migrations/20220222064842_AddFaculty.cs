using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisManagement.Migrations
{
    public partial class AddFaculty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleType = table.Column<string>(type: "varchar", nullable: false),
                    SubjectName = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Faculties_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
