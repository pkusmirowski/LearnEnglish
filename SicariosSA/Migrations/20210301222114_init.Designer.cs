﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SicariosSA.Models;

namespace SicariosSA.Migrations
{
    [DbContext(typeof(SicariosContext))]
    [Migration("20210301222114_init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Polish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SicariosSA.Models.TasksAbc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TaskName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("taskName");

                    b.HasKey("Id");

                    b.ToTable("TasksABC");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksAbcanswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorrectAnswer")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("correctAnswer");

                    b.Property<string>("Explanation")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("explanation");

                    b.Property<int?>("IdTasksAbc")
                        .HasColumnType("int")
                        .HasColumnName("idTasksABC");

                    b.Property<string>("Option1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("option1");

                    b.Property<string>("Option1Pl")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("option1PL");

                    b.Property<string>("Option2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("option2");

                    b.Property<string>("Option2Pl")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("option2PL");

                    b.Property<string>("Option3")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("option3");

                    b.Property<string>("Option3Pl")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("option3PL");

                    b.Property<string>("Question")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("question");

                    b.HasKey("Id");

                    b.HasIndex("IdTasksAbc");

                    b.ToTable("TasksABCAnswer");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Explanation")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("explanation");

                    b.Property<string>("TaskName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("taskName");

                    b.Property<string>("TextToFill")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("textToFill");

                    b.HasKey("Id");

                    b.ToTable("TasksGaps");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsCorrectAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.HasIndex("IdTasksGaps");

                    b.HasIndex("IdTasksPossibleAnswer");

                    b.ToTable("TasksGapsCorrectAnswer");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsPossibleAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.HasIndex("IdTasksGaps");

                    b.ToTable("TasksGapsPossibleAnswer");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsZabc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Explanation")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("explanation");

                    b.Property<string>("TaskName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("taskName");

                    b.Property<string>("TextToFill")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("textToFill");

                    b.HasKey("Id");

                    b.ToTable("TasksGapsZABC");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsZabccorrectAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdTasksGapsAbcpossibleAnswer")
                        .HasColumnType("int")
                        .HasColumnName("idTasksGapsABCPossibleAnswer");

                    b.Property<string>("Number")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("number");

                    b.HasKey("Id");

                    b.HasIndex("IdTasksGapsAbcpossibleAnswer");

                    b.ToTable("TasksGapsZABCCorrectAnswer");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsZabcpack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abcnumber")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("ABCnumber");

                    b.HasKey("Id");

                    b.ToTable("TasksGapsZABCPack");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsZabcpossibleAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.HasIndex("IdTasksGapsAbc");

                    b.HasIndex("IdTasksGapsAbcpack");

                    b.ToTable("TasksGapsZABCPossibleAnswer");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksAbcanswer", b =>
                {
                    b.HasOne("SicariosSA.Models.TasksAbc", "IdTasksAbcNavigation")
                        .WithMany("TasksAbcanswers")
                        .HasForeignKey("IdTasksAbc")
                        .HasConstraintName("FK_TasksABCAnswer_TasksABC");

                    b.Navigation("IdTasksAbcNavigation");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsCorrectAnswer", b =>
                {
                    b.HasOne("SicariosSA.Models.TasksGap", "IdTasksGapsNavigation")
                        .WithMany("TasksGapsCorrectAnswers")
                        .HasForeignKey("IdTasksGaps")
                        .HasConstraintName("FK_TasksGapsCorrectAnswer_TasksGaps");

                    b.HasOne("SicariosSA.Models.TasksGapsPossibleAnswer", "IdTasksPossibleAnswerNavigation")
                        .WithMany("TasksGapsCorrectAnswers")
                        .HasForeignKey("IdTasksPossibleAnswer")
                        .HasConstraintName("FK_TasksGapsCorrectAnswer_TasksPossibleAnswer");

                    b.Navigation("IdTasksGapsNavigation");

                    b.Navigation("IdTasksPossibleAnswerNavigation");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsPossibleAnswer", b =>
                {
                    b.HasOne("SicariosSA.Models.TasksGap", "IdTasksGapsNavigation")
                        .WithMany("TasksGapsPossibleAnswers")
                        .HasForeignKey("IdTasksGaps")
                        .HasConstraintName("FK_TasksPossibleAnswer_TasksGaps");

                    b.Navigation("IdTasksGapsNavigation");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsZabccorrectAnswer", b =>
                {
                    b.HasOne("SicariosSA.Models.TasksGapsZabcpossibleAnswer", "IdTasksGapsAbcpossibleAnswerNavigation")
                        .WithMany("TasksGapsZabccorrectAnswers")
                        .HasForeignKey("IdTasksGapsAbcpossibleAnswer")
                        .HasConstraintName("FK_TasksGapsZABCCorrectAnswer_TasksGapsZABCPossibleAnswer");

                    b.Navigation("IdTasksGapsAbcpossibleAnswerNavigation");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsZabcpossibleAnswer", b =>
                {
                    b.HasOne("SicariosSA.Models.TasksGapsZabc", "IdTasksGapsAbcNavigation")
                        .WithMany("TasksGapsZabcpossibleAnswers")
                        .HasForeignKey("IdTasksGapsAbc")
                        .HasConstraintName("FK_TasksGapsZABCPossibleAnswer_TasksGapsZABC");

                    b.HasOne("SicariosSA.Models.TasksGapsZabcpack", "IdTasksGapsAbcpackNavigation")
                        .WithMany("TasksGapsZabcpossibleAnswers")
                        .HasForeignKey("IdTasksGapsAbcpack")
                        .HasConstraintName("FK_TasksGapsZABCPossibleAnswer_TasksGapsZABCPack");

                    b.Navigation("IdTasksGapsAbcNavigation");

                    b.Navigation("IdTasksGapsAbcpackNavigation");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksAbc", b =>
                {
                    b.Navigation("TasksAbcanswers");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGap", b =>
                {
                    b.Navigation("TasksGapsCorrectAnswers");

                    b.Navigation("TasksGapsPossibleAnswers");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsPossibleAnswer", b =>
                {
                    b.Navigation("TasksGapsCorrectAnswers");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsZabc", b =>
                {
                    b.Navigation("TasksGapsZabcpossibleAnswers");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsZabcpack", b =>
                {
                    b.Navigation("TasksGapsZabcpossibleAnswers");
                });

            modelBuilder.Entity("SicariosSA.Models.TasksGapsZabcpossibleAnswer", b =>
                {
                    b.Navigation("TasksGapsZabccorrectAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
