using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisManagement.Migrations
{
    public partial class AddThesisAssign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThesisAssigns",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTitle = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ProjectDesc = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    ProfessorID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    CmptPercent = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThesisAssigns", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_ThesisAssigns_Faculties_ProfessorID",
                        column: x => x.ProfessorID,
                        principalTable: "Faculties",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThesisAssigns_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "EnrollId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThesisAssigns_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThesisAssigns_ProfessorID",
                table: "ThesisAssigns",
                column: "ProfessorID");

            migrationBuilder.CreateIndex(
                name: "IX_ThesisAssigns_StudentID",
                table: "ThesisAssigns",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_ThesisAssigns_SubjectID",
                table: "ThesisAssigns",
                column: "SubjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThesisAssigns");
        }
    }
}
