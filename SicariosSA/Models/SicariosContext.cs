using Microsoft.EntityFrameworkCore;

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

        public virtual DbSet<AudioTasksGap> AudioTasksGaps { get; set; }
        public virtual DbSet<AudioTasksGapsCorrectAnswer> AudioTasksGapsCorrectAnswers { get; set; }
        public virtual DbSet<DialogueTasksGap> DialogueTasksGaps { get; set; }
        public virtual DbSet<DialogueTasksGapsAnswerPack> DialogueTasksGapsAnswerPacks { get; set; }
        public virtual DbSet<DialogueTasksGapsCorrectAnswer> DialogueTasksGapsCorrectAnswers { get; set; }
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

            modelBuilder.Entity<AudioTasksGap>(entity =>
            {
                entity.Property(e => e.Explanation).IsUnicode(false);

                entity.Property(e => e.SoundtrackName).IsUnicode(false);

                entity.Property(e => e.TaskName).IsUnicode(false);
            });

            modelBuilder.Entity<AudioTasksGapsCorrectAnswer>(entity =>
            {
                entity.Property(e => e.Answer1).IsUnicode(false);

                entity.Property(e => e.Answer1Pl).IsUnicode(false);

                entity.Property(e => e.Answer2).IsUnicode(false);

                entity.Property(e => e.Answer2Pl).IsUnicode(false);

                entity.Property(e => e.Answer3).IsUnicode(false);

                entity.Property(e => e.Answer3Pl).IsUnicode(false);

                entity.Property(e => e.Answer4).IsUnicode(false);

                entity.Property(e => e.Answer4Pl).IsUnicode(false);

                entity.HasOne(d => d.IdAudioTaskNavigation)
                    .WithMany(p => p.AudioTasksGapsCorrectAnswers)
                    .HasForeignKey(d => d.IdAudioTask)
                    .HasConstraintName("FK_AudioTaskCorrectAnswer_AudioTask");
            });

            modelBuilder.Entity<DialogueTasksGap>(entity =>
            {
                entity.Property(e => e.Explanation).IsUnicode(false);

                entity.Property(e => e.TaskName).IsUnicode(false);

                entity.Property(e => e.TextToFill).IsUnicode(false);
            });

            modelBuilder.Entity<DialogueTasksGapsAnswerPack>(entity =>
            {
                entity.Property(e => e.AnswerNumber).IsUnicode(false);

                entity.HasOne(d => d.IdDialogueTasksGapsNavigation)
                    .WithMany(p => p.DialogueTasksGapsAnswerPacks)
                    .HasForeignKey(d => d.IdDialogueTasksGaps)
                    .HasConstraintName("FK_DialogueTasksGapsAnswerPack_DialogueTasksGaps1");

                entity.HasOne(d => d.IdDialogueTasksGaps1)
                    .WithMany(p => p.DialogueTasksGapsAnswerPacks)
                    .HasForeignKey(d => d.IdDialogueTasksGaps)
                    .HasConstraintName("FK_DialogueTasksGapsAnswerPack_DialogueTasksGapsCorrectAnswer");
            });

            modelBuilder.Entity<DialogueTasksGapsCorrectAnswer>(entity =>
            {
                entity.Property(e => e.CorrectAnswer).IsUnicode(false);

                entity.Property(e => e.CorrectAnswerPl).IsUnicode(false);

                entity.HasOne(d => d.IdDialogueTasksGapsNavigation)
                    .WithMany(p => p.DialogueTasksGapsCorrectAnswers)
                    .HasForeignKey(d => d.IdDialogueTasksGaps)
                    .HasConstraintName("FK_DialogueTasksGapsCorrectAnswer_DialogueTasksGaps");
            });

            modelBuilder.Entity<TasksAbc>(entity =>
            {
                entity.Property(e => e.TaskName).IsUnicode(false);
            });

            modelBuilder.Entity<TasksAbcanswer>(entity =>
            {
                entity.Property(e => e.CorrectAnswer).IsUnicode(false);

                entity.Property(e => e.Explanation).IsUnicode(false);

                entity.Property(e => e.Option1).IsUnicode(false);

                entity.Property(e => e.Option1Pl).IsUnicode(false);

                entity.Property(e => e.Option2).IsUnicode(false);

                entity.Property(e => e.Option2Pl).IsUnicode(false);

                entity.Property(e => e.Option3).IsUnicode(false);

                entity.Property(e => e.Option3Pl).IsUnicode(false);

                entity.Property(e => e.Question).IsUnicode(false);

                entity.HasOne(d => d.IdTasksAbcNavigation)
                    .WithMany(p => p.TasksAbcanswers)
                    .HasForeignKey(d => d.IdTasksAbc)
                    .HasConstraintName("FK_TasksABCAnswer_TasksABC");
            });

            modelBuilder.Entity<TasksGap>(entity =>
            {
                entity.Property(e => e.Explanation).IsUnicode(false);

                entity.Property(e => e.TaskName).IsUnicode(false);

                entity.Property(e => e.TextToFill).IsUnicode(false);
            });

            modelBuilder.Entity<TasksGapsCorrectAnswer>(entity =>
            {
                entity.Property(e => e.Number).IsUnicode(false);

                entity.HasOne(d => d.IdTasksGapsNavigation)
                    .WithMany(p => p.TasksGapsCorrectAnswers)
                    .HasForeignKey(d => d.IdTasksGaps)
                    .HasConstraintName("FK_TasksGapsCorrectAnswer_TasksGaps");

                entity.HasOne(d => d.IdTasksPossibleAnswerNavigation)
                    .WithMany(p => p.TasksGapsCorrectAnswers)
                    .HasForeignKey(d => d.IdTasksPossibleAnswer)
                    .HasConstraintName("FK_TasksGapsCorrectAnswer_TasksPossibleAnswer");
            });

            modelBuilder.Entity<TasksGapsPossibleAnswer>(entity =>
            {
                entity.Property(e => e.PossibleAnswer).IsUnicode(false);

                entity.Property(e => e.PossibleAnswerPl).IsUnicode(false);

                entity.HasOne(d => d.IdTasksGapsNavigation)
                    .WithMany(p => p.TasksGapsPossibleAnswers)
                    .HasForeignKey(d => d.IdTasksGaps)
                    .HasConstraintName("FK_TasksPossibleAnswer_TasksGaps");
            });

            modelBuilder.Entity<TasksGapsZabc>(entity =>
            {
                entity.Property(e => e.Explanation).IsUnicode(false);

                entity.Property(e => e.TaskName).IsUnicode(false);

                entity.Property(e => e.TextToFill).IsUnicode(false);
            });

            modelBuilder.Entity<TasksGapsZabccorrectAnswer>(entity =>
            {
                entity.Property(e => e.Number).IsUnicode(false);

                entity.HasOne(d => d.IdTasksGapsAbcNavigation)
                    .WithMany(p => p.TasksGapsZabccorrectAnswers)
                    .HasForeignKey(d => d.IdTasksGapsAbc)
                    .HasConstraintName("FK_TasksGapsZABCCorrectAnswer_TasksGapsZABC");

                entity.HasOne(d => d.IdTasksGapsAbcpossibleAnswerNavigation)
                    .WithMany(p => p.TasksGapsZabccorrectAnswers)
                    .HasForeignKey(d => d.IdTasksGapsAbcpossibleAnswer)
                    .HasConstraintName("FK_TasksGapsZABCCorrectAnswer_TasksGapsZABCPossibleAnswer");
            });

            modelBuilder.Entity<TasksGapsZabcpack>(entity =>
            {
                entity.Property(e => e.Abcnumber).IsUnicode(false);
            });

            modelBuilder.Entity<TasksGapsZabcpossibleAnswer>(entity =>
            {
                entity.Property(e => e.PossibleAnswer).IsUnicode(false);

                entity.Property(e => e.PossibleAnswerPl).IsUnicode(false);

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
