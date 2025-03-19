using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnEnglish.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AudioTasksGaps",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taskName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    explanation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    soundtrackName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioTasksGaps", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DialogueTasksGaps",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taskName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    explanation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    textToFill = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DialogueTasksGaps", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TasksABC",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taskName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksABC", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TasksGaps",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taskName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    explanation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    textToFill = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksGaps", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TasksGapsZABC",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taskName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    explanation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    textToFill = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksGapsZABC", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TasksGapsZABCPack",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABCnumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksGapsZABCPack", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AudioTasksGapsCorrectAnswer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    answer1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    answer2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    answer3 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    answer4 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    answer1PL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    answer2PL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    answer3PL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    answer4PL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    idAudioTask = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioTasksGapsCorrectAnswer", x => x.id);
                    table.ForeignKey(
                        name: "FK_AudioTaskCorrectAnswer_AudioTask",
                        column: x => x.idAudioTask,
                        principalTable: "AudioTasksGaps",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DialogueTasksGapsCorrectAnswer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    correctAnswer = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    idDialogueTasksGaps = table.Column<int>(type: "int", nullable: true),
                    correctAnswerPl = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GapNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DialogueTasksGapsCorrectAnswer", x => x.id);
                    table.ForeignKey(
                        name: "FK_DialogueTasksGapsCorrectAnswer_DialogueTasksGaps1",
                        column: x => x.idDialogueTasksGaps,
                        principalTable: "DialogueTasksGaps",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "TasksABCAnswer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    option1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    option2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    option3 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    option1PL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    option2PL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    option3PL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    correctAnswer = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    idTasksABC = table.Column<int>(type: "int", nullable: false),
                    explanation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksABCAnswer", x => x.id);
                    table.ForeignKey(
                        name: "FK_TasksABCAnswer_TasksABC",
                        column: x => x.idTasksABC,
                        principalTable: "TasksABC",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "id");
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
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_TasksGapsZABCPossibleAnswer_TasksGapsZABCPack",
                        column: x => x.idTasksGapsABCPack,
                        principalTable: "TasksGapsZABCPack",
                        principalColumn: "id");
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
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_TasksGapsCorrectAnswer_TasksPossibleAnswer",
                        column: x => x.idTasksPossibleAnswer,
                        principalTable: "TasksGapsPossibleAnswer",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "TasksGapsZABCCorrectAnswer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    idTasksGapsABCPossibleAnswer = table.Column<int>(type: "int", nullable: true),
                    idTasksGapsABC = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksGapsZABCCorrectAnswer", x => x.id);
                    table.ForeignKey(
                        name: "FK_TasksGapsZABCCorrectAnswer_TasksGapsZABC",
                        column: x => x.idTasksGapsABC,
                        principalTable: "TasksGapsZABC",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_TasksGapsZABCCorrectAnswer_TasksGapsZABCPossibleAnswer",
                        column: x => x.idTasksGapsABCPossibleAnswer,
                        principalTable: "TasksGapsZABCPossibleAnswer",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AudioTasksGapsCorrectAnswer_idAudioTask",
                table: "AudioTasksGapsCorrectAnswer",
                column: "idAudioTask");

            migrationBuilder.CreateIndex(
                name: "IX_DialogueTasksGapsCorrectAnswer_idDialogueTasksGaps",
                table: "DialogueTasksGapsCorrectAnswer",
                column: "idDialogueTasksGaps");

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
                name: "IX_TasksGapsZABCCorrectAnswer_idTasksGapsABC",
                table: "TasksGapsZABCCorrectAnswer",
                column: "idTasksGapsABC");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AudioTasksGapsCorrectAnswer");

            migrationBuilder.DropTable(
                name: "DialogueTasksGapsCorrectAnswer");

            migrationBuilder.DropTable(
                name: "TasksABCAnswer");

            migrationBuilder.DropTable(
                name: "TasksGapsCorrectAnswer");

            migrationBuilder.DropTable(
                name: "TasksGapsZABCCorrectAnswer");

            migrationBuilder.DropTable(
                name: "AudioTasksGaps");

            migrationBuilder.DropTable(
                name: "DialogueTasksGaps");

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
