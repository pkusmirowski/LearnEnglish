using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SicariosSA.Models
{
    public partial class SicariosContext : DbContext
    {
        public SicariosContext()
        {
        }

        public SicariosContext(DbContextOptions<SicariosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TasksAbc> TasksAbcs { get; set; }
        public virtual DbSet<TasksAbcanswer> TasksAbcanswers { get; set; }
        public virtual DbSet<TasksGap> TasksGaps { get; set; }
        public virtual DbSet<TasksGapsCorrectAnswer> TasksGapsCorrectAnswers { get; set; }
        public virtual DbSet<TasksGapsPossibleAnswer> TasksGapsPossibleAnswers { get; set; }
        public virtual DbSet<TasksGapsZabc> TasksGapsZabcs { get; set; }
        public virtual DbSet<TasksGapsZabccorrectAnswer> TasksGapsZabccorrectAnswers { get; set; }
        public virtual DbSet<TasksGapsZabcpack> TasksGapsZabcpacks { get; set; }
        public virtual DbSet<TasksGapsZabcpossibleAnswer> TasksGapsZabcpossibleAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Polish_CI_AS");

            modelBuilder.Entity<TasksAbcanswer>(entity =>
            {
                entity.HasOne(d => d.IdTasksAbcNavigation)
                    .WithMany(p => p.TasksAbcanswers)
                    .HasForeignKey(d => d.IdTasksAbc)
                    .HasConstraintName("FK_TasksABCAnswer_TasksABC");
            });

            modelBuilder.Entity<TasksGapsCorrectAnswer>(entity =>
            {
                entity.Property(e => e.Number).IsUnicode(false);

                entity.HasOne(d => d.IdTasksPossibleAnswerNavigation)
                    .WithMany(p => p.TasksGapsCorrectAnswers)
                    .HasForeignKey(d => d.IdTasksPossibleAnswer)
                    .HasConstraintName("FK_TasksGapsCorrectAnswer_TasksPossibleAnswer");
            });

            modelBuilder.Entity<TasksGapsPossibleAnswer>(entity =>
            {
                entity.HasOne(d => d.IdTasksGapsNavigation)
                    .WithMany(p => p.TasksGapsPossibleAnswers)
                    .HasForeignKey(d => d.IdTasksGaps)
                    .HasConstraintName("FK_TasksPossibleAnswer_TasksGaps");
            });

            modelBuilder.Entity<TasksGapsZabccorrectAnswer>(entity =>
            {
                entity.HasOne(d => d.IdTasksGapsAbcpossibleAnswerNavigation)
                    .WithMany(p => p.TasksGapsZabccorrectAnswers)
                    .HasForeignKey(d => d.IdTasksGapsAbcpossibleAnswer)
                    .HasConstraintName("FK_TasksGapsZABCCorrectAnswer_TasksGapsZABCPossibleAnswer");
            });

            modelBuilder.Entity<TasksGapsZabcpossibleAnswer>(entity =>
            {
                entity.HasOne(d => d.IdTasksGapsAbcNavigation)
                    .WithMany(p => p.TasksGapsZabcpossibleAnswers)
                    .HasForeignKey(d => d.IdTasksGapsAbc)
                    .HasConstraintName("FK_TasksGapsZABCPossibleAnswer_TasksGapsZABC");

                entity.HasOne(d => d.IdTasksGapsAbcpackNavigation)
                    .WithMany(p => p.TasksGapsZabcpossibleAnswers)
                    .HasForeignKey(d => d.IdTasksGapsAbcpack)
                    .HasConstraintName("FK_TasksGapsZABCPossibleAnswer_TasksGapsZABCPack");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
