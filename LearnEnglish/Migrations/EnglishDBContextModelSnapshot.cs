﻿// <auto-generated />
using LearnEnglish.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearnEnglish.Migrations
{
    [DbContext(typeof(EnglishDBContext))]
    partial class EnglishDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LearnEnglish.Models.AudioTasksGap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("explanation");

                    b.Property<string>("SoundtrackName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("soundtrackName");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("taskName");

                    b.HasKey("Id");

                    b.ToTable("AudioTasksGaps");
                });

            modelBuilder.Entity("LearnEnglish.Models.AudioTasksGapsCorrectAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer1")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("answer1");

                    b.Property<string>("Answer1Pl")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("answer1PL");

                    b.Property<string>("Answer2")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("answer2");

                    b.Property<string>("Answer2Pl")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("answer2PL");

                    b.Property<string>("Answer3")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("answer3");

                    b.Property<string>("Answer3Pl")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("answer3PL");

                    b.Property<string>("Answer4")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("answer4");

                    b.Property<string>("Answer4Pl")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("answer4PL");

                    b.Property<int>("IdAudioTask")
                        .HasColumnType("int")
                        .HasColumnName("idAudioTask");

                    b.HasKey("Id");

                    b.HasIndex("IdAudioTask");

                    b.ToTable("AudioTasksGapsCorrectAnswer", (string)null);
                });

            modelBuilder.Entity("LearnEnglish.Models.DialogueTasksGap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("explanation");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("taskName");

                    b.Property<string>("TextToFill")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("textToFill");

                    b.HasKey("Id");

                    b.ToTable("DialogueTasksGaps");
                });

            modelBuilder.Entity("LearnEnglish.Models.DialogueTasksGapsCorrectAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CorrectAnswer")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("correctAnswer");

                    b.Property<string>("CorrectAnswerPl")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("correctAnswerPl");

                    b.Property<int?>("GapNumber")
                        .HasColumnType("int");

                    b.Property<int?>("IdDialogueTasksGaps")
                        .HasColumnType("int")
                        .HasColumnName("idDialogueTasksGaps");

                    b.HasKey("Id");

                    b.HasIndex("IdDialogueTasksGaps");

                    b.ToTable("DialogueTasksGapsCorrectAnswer", (string)null);
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksAbc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TaskName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("taskName");

                    b.HasKey("Id");

                    b.ToTable("TasksABC", (string)null);
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksAbcanswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("correctAnswer");

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("explanation");

                    b.Property<int>("IdTasksAbc")
                        .HasColumnType("int")
                        .HasColumnName("idTasksABC");

                    b.Property<string>("Option1")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("option1");

                    b.Property<string>("Option1Pl")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("option1PL");

                    b.Property<string>("Option2")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("option2");

                    b.Property<string>("Option2Pl")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("option2PL");

                    b.Property<string>("Option3")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("option3");

                    b.Property<string>("Option3Pl")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("option3PL");

                    b.Property<string>("Question")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("question");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdTasksAbc" }, "IX_TasksABCAnswer_idTasksABC");

                    b.ToTable("TasksABCAnswer", (string)null);
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("explanation");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("taskName");

                    b.Property<string>("TextToFill")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("textToFill");

                    b.HasKey("Id");

                    b.ToTable("TasksGaps");
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsCorrectAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdTasksGaps")
                        .HasColumnType("int")
                        .HasColumnName("idTasksGaps");

                    b.Property<int?>("IdTasksPossibleAnswer")
                        .HasColumnType("int")
                        .HasColumnName("idTasksPossibleAnswer");

                    b.Property<string>("Number")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("number");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdTasksGaps" }, "IX_TasksGapsCorrectAnswer_idTasksGaps");

                    b.HasIndex(new[] { "IdTasksPossibleAnswer" }, "IX_TasksGapsCorrectAnswer_idTasksPossibleAnswer");

                    b.ToTable("TasksGapsCorrectAnswer", (string)null);
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsPossibleAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdTasksGaps")
                        .HasColumnType("int")
                        .HasColumnName("idTasksGaps");

                    b.Property<string>("PossibleAnswer")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("possibleAnswer");

                    b.Property<string>("PossibleAnswerPl")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("possibleAnswerPL");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdTasksGaps" }, "IX_TasksGapsPossibleAnswer_idTasksGaps");

                    b.ToTable("TasksGapsPossibleAnswer", (string)null);
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsZabc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("explanation");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("taskName");

                    b.Property<string>("TextToFill")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("textToFill");

                    b.HasKey("Id");

                    b.ToTable("TasksGapsZABC", (string)null);
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsZabccorrectAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdTasksGapsAbc")
                        .HasColumnType("int")
                        .HasColumnName("idTasksGapsABC");

                    b.Property<int?>("IdTasksGapsAbcpossibleAnswer")
                        .HasColumnType("int")
                        .HasColumnName("idTasksGapsABCPossibleAnswer");

                    b.Property<string>("Number")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("number");

                    b.HasKey("Id");

                    b.HasIndex("IdTasksGapsAbc");

                    b.HasIndex(new[] { "IdTasksGapsAbcpossibleAnswer" }, "IX_TasksGapsZABCCorrectAnswer_idTasksGapsABCPossibleAnswer");

                    b.ToTable("TasksGapsZABCCorrectAnswer", (string)null);
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsZabcpack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Abcnumber")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("ABCnumber");

                    b.HasKey("Id");

                    b.ToTable("TasksGapsZABCPack", (string)null);
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsZabcpossibleAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdTasksGapsAbc")
                        .HasColumnType("int")
                        .HasColumnName("idTasksGapsABC");

                    b.Property<int?>("IdTasksGapsAbcpack")
                        .HasColumnType("int")
                        .HasColumnName("idTasksGapsABCPack");

                    b.Property<string>("PossibleAnswer")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("possibleAnswer");

                    b.Property<string>("PossibleAnswerPl")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("possibleAnswerPL");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdTasksGapsAbc" }, "IX_TasksGapsZABCPossibleAnswer_idTasksGapsABC");

                    b.HasIndex(new[] { "IdTasksGapsAbcpack" }, "IX_TasksGapsZABCPossibleAnswer_idTasksGapsABCPack");

                    b.ToTable("TasksGapsZABCPossibleAnswer", (string)null);
                });

            modelBuilder.Entity("LearnEnglish.Models.AudioTasksGapsCorrectAnswer", b =>
                {
                    b.HasOne("LearnEnglish.Models.AudioTasksGap", "IdAudioTaskNavigation")
                        .WithMany("AudioTasksGapsCorrectAnswers")
                        .HasForeignKey("IdAudioTask")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AudioTaskCorrectAnswer_AudioTask");

                    b.Navigation("IdAudioTaskNavigation");
                });

            modelBuilder.Entity("LearnEnglish.Models.DialogueTasksGapsCorrectAnswer", b =>
                {
                    b.HasOne("LearnEnglish.Models.DialogueTasksGap", "IdDialogueTasksGapsNavigation")
                        .WithMany("DialogueTasksGapsCorrectAnswers")
                        .HasForeignKey("IdDialogueTasksGaps")
                        .HasConstraintName("FK_DialogueTasksGapsCorrectAnswer_DialogueTasksGaps1");

                    b.Navigation("IdDialogueTasksGapsNavigation");
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksAbcanswer", b =>
                {
                    b.HasOne("LearnEnglish.Models.TasksAbc", "IdTasksAbcNavigation")
                        .WithMany("TasksAbcanswers")
                        .HasForeignKey("IdTasksAbc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TasksABCAnswer_TasksABC");

                    b.Navigation("IdTasksAbcNavigation");
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsCorrectAnswer", b =>
                {
                    b.HasOne("LearnEnglish.Models.TasksGap", "IdTasksGapsNavigation")
                        .WithMany("TasksGapsCorrectAnswers")
                        .HasForeignKey("IdTasksGaps")
                        .HasConstraintName("FK_TasksGapsCorrectAnswer_TasksGaps");

                    b.HasOne("LearnEnglish.Models.TasksGapsPossibleAnswer", "IdTasksPossibleAnswerNavigation")
                        .WithMany("TasksGapsCorrectAnswers")
                        .HasForeignKey("IdTasksPossibleAnswer")
                        .HasConstraintName("FK_TasksGapsCorrectAnswer_TasksPossibleAnswer");

                    b.Navigation("IdTasksGapsNavigation");

                    b.Navigation("IdTasksPossibleAnswerNavigation");
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsPossibleAnswer", b =>
                {
                    b.HasOne("LearnEnglish.Models.TasksGap", "IdTasksGapsNavigation")
                        .WithMany("TasksGapsPossibleAnswers")
                        .HasForeignKey("IdTasksGaps")
                        .HasConstraintName("FK_TasksPossibleAnswer_TasksGaps");

                    b.Navigation("IdTasksGapsNavigation");
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsZabccorrectAnswer", b =>
                {
                    b.HasOne("LearnEnglish.Models.TasksGapsZabc", "IdTasksGapsAbcNavigation")
                        .WithMany("TasksGapsZabccorrectAnswers")
                        .HasForeignKey("IdTasksGapsAbc")
                        .HasConstraintName("FK_TasksGapsZABCCorrectAnswer_TasksGapsZABC");

                    b.HasOne("LearnEnglish.Models.TasksGapsZabcpossibleAnswer", "IdTasksGapsAbcpossibleAnswerNavigation")
                        .WithMany("TasksGapsZabccorrectAnswers")
                        .HasForeignKey("IdTasksGapsAbcpossibleAnswer")
                        .HasConstraintName("FK_TasksGapsZABCCorrectAnswer_TasksGapsZABCPossibleAnswer");

                    b.Navigation("IdTasksGapsAbcNavigation");

                    b.Navigation("IdTasksGapsAbcpossibleAnswerNavigation");
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsZabcpossibleAnswer", b =>
                {
                    b.HasOne("LearnEnglish.Models.TasksGapsZabc", "IdTasksGapsAbcNavigation")
                        .WithMany("TasksGapsZabcpossibleAnswers")
                        .HasForeignKey("IdTasksGapsAbc")
                        .HasConstraintName("FK_TasksGapsZABCPossibleAnswer_TasksGapsZABC");

                    b.HasOne("LearnEnglish.Models.TasksGapsZabcpack", "IdTasksGapsAbcpackNavigation")
                        .WithMany("TasksGapsZabcpossibleAnswers")
                        .HasForeignKey("IdTasksGapsAbcpack")
                        .HasConstraintName("FK_TasksGapsZABCPossibleAnswer_TasksGapsZABCPack");

                    b.Navigation("IdTasksGapsAbcNavigation");

                    b.Navigation("IdTasksGapsAbcpackNavigation");
                });

            modelBuilder.Entity("LearnEnglish.Models.AudioTasksGap", b =>
                {
                    b.Navigation("AudioTasksGapsCorrectAnswers");
                });

            modelBuilder.Entity("LearnEnglish.Models.DialogueTasksGap", b =>
                {
                    b.Navigation("DialogueTasksGapsCorrectAnswers");
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksAbc", b =>
                {
                    b.Navigation("TasksAbcanswers");
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGap", b =>
                {
                    b.Navigation("TasksGapsCorrectAnswers");

                    b.Navigation("TasksGapsPossibleAnswers");
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsPossibleAnswer", b =>
                {
                    b.Navigation("TasksGapsCorrectAnswers");
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsZabc", b =>
                {
                    b.Navigation("TasksGapsZabccorrectAnswers");

                    b.Navigation("TasksGapsZabcpossibleAnswers");
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsZabcpack", b =>
                {
                    b.Navigation("TasksGapsZabcpossibleAnswers");
                });

            modelBuilder.Entity("LearnEnglish.Models.TasksGapsZabcpossibleAnswer", b =>
                {
                    b.Navigation("TasksGapsZabccorrectAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
