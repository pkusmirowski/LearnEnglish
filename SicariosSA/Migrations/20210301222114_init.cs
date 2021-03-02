using Microsoft.EntityFrameworkCore.Migrations;

namespace SicariosSA.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TasksABC",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taskName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table => table.PrimaryKey("PK_TasksABC", x => x.id));

            migrationBuilder.CreateTable(
                name: "TasksGaps",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taskName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    explanation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    textToFill = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table => table.PrimaryKey("PK_TasksGaps", x => x.id));

            migrationBuilder.CreateTable(
                name: "TasksGapsZABC",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taskName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    explanation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    textToFill = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table => table.PrimaryKey("PK_TasksGapsZABC", x => x.id));

            migrationBuilder.CreateTable(
                name: "TasksGapsZABCPack",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABCnumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table => table.PrimaryKey("PK_TasksGapsZABCPack", x => x.id));

            migrationBuilder.CreateTable(
                name: "TasksABCAnswer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    option1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    option2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    option3 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    option1PL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    option2PL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    option3PL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    correctAnswer = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    idTasksABC = table.Column<int>(type: "int", nullable: true),
                    explanation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksABCAnswer", x => x.id);
                    table.ForeignKey(
                        name: "FK_TasksABCAnswer_TasksABC",
                        column: x => x.idTasksABC,
                        principalTable: "TasksABC",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TasksGapsPossibleAnswer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTasksGaps = table.Column<int>(type: "int", nullable: true),
                    possibleAnswer = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    possibleAnswerPL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksGapsPossibleAnswer", x => x.id);
                    table.ForeignKey(
                        name: "FK_TasksPossibleAnswer_TasksGaps",
                        column: x => x.idTasksGaps,
                        principalTable: "TasksGaps",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TasksGapsZABCPossibleAnswer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTasksGapsABC = table.Column<int>(type: "int", nullable: true),
                    idTasksGapsABCPack = table.Column<int>(type: "int", nullable: true),
                    possibleAnswer = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    possibleAnswerPL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksGapsZABCPossibleAnswer", x => x.id);
                    table.ForeignKey(
                        name: "FK_TasksGapsZABCPossibleAnswer_TasksGapsZABC",
                        column: x => x.idTasksGapsABC,
                        principalTable: "TasksGapsZABC",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TasksGapsZABCPossibleAnswer_TasksGapsZABCPack",
                        column: x => x.idTasksGapsABCPack,
                        principalTable: "TasksGapsZABCPack",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TasksGapsCorrectAnswer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    idTasksPossibleAnswer = table.Column<int>(type: "int", nullable: true),
                    idTasksGaps = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksGapsCorrectAnswer", x => x.id);
                    table.ForeignKey(
                        name: "FK_TasksGapsCorrectAnswer_TasksGaps",
                        column: x => x.idTasksGaps,
                        principalTable: "TasksGaps",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TasksGapsCorrectAnswer_TasksPossibleAnswer",
                        column: x => x.idTasksPossibleAnswer,
                        principalTable: "TasksGapsPossibleAnswer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TasksGapsZABCCorrectAnswer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    idTasksGapsABCPossibleAnswer = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksGapsZABCCorrectAnswer", x => x.id);
                    table.ForeignKey(
                        name: "FK_TasksGapsZABCCorrectAnswer_TasksGapsZABCPossibleAnswer",
                        column: x => x.idTasksGapsABCPossibleAnswer,
                        principalTable: "TasksGapsZABCPossibleAnswer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TasksABCAnswer_idTasksABC",
                table: "TasksABCAnswer",
                column: "idTasksABC");

            migrationBuilder.CreateIndex(
                name: "IX_TasksGapsCorrectAnswer_idTasksGaps",
                table: "TasksGapsCorrectAnswer",
                column: "idTasksGaps");

            migrationBuilder.CreateIndex(
                name: "IX_TasksGapsCorrectAnswer_idTasksPossibleAnswer",
                table: "TasksGapsCorrectAnswer",
                column: "idTasksPossibleAnswer");

            migrationBuilder.CreateIndex(
                name: "IX_TasksGapsPossibleAnswer_idTasksGaps",
                table: "TasksGapsPossibleAnswer",
                column: "idTasksGaps");

            migrationBuilder.CreateIndex(
                name: "IX_TasksGapsZABCCorrectAnswer_idTasksGapsABCPossibleAnswer",
                table: "TasksGapsZABCCorrectAnswer",
                column: "idTasksGapsABCPossibleAnswer");

            migrationBuilder.CreateIndex(
                name: "IX_TasksGapsZABCPossibleAnswer_idTasksGapsABC",
                table: "TasksGapsZABCPossibleAnswer",
                column: "idTasksGapsABC");

            migrationBuilder.CreateIndex(
                name: "IX_TasksGapsZABCPossibleAnswer_idTasksGapsABCPack",
                table: "TasksGapsZABCPossibleAnswer",
                column: "idTasksGapsABCPack");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TasksABCAnswer");

            migrationBuilder.DropTable(
                name: "TasksGapsCorrectAnswer");

            migrationBuilder.DropTable(
                name: "TasksGapsZABCCorrectAnswer");

            migrationBuilder.DropTable(
                name: "TasksABC");

            migrationBuilder.DropTable(
                name: "TasksGapsPossibleAnswer");

            migrationBuilder.DropTable(
                name: "TasksGapsZABCPossibleAnswer");

            migrationBuilder.DropTable(
                name: "TasksGaps");

            migrationBuilder.DropTable(
                name: "TasksGapsZABC");

            migrationBuilder.DropTable(
                name: "TasksGapsZABCPack");
        }
    }
}
