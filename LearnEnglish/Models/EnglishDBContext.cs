using Microsoft.EntityFrameworkCore;

namespace LearnEnglish.Models
{
    public partial class EnglishDBContext : DbContext
    {
        public EnglishDBContext()
        {
        }

        public EnglishDBContext(DbContextOptions<EnglishDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AudioTasksGap> AudioTasksGaps { get; set; } = null!;
        public virtual DbSet<AudioTasksGapsCorrectAnswer> AudioTasksGapsCorrectAnswers { get; set; } = null!;
        public virtual DbSet<DialogueTasksGap> DialogueTasksGaps { get; set; } = null!;
        public virtual DbSet<DialogueTasksGapsCorrectAnswer> DialogueTasksGapsCorrectAnswers { get; set; } = null!;
        public virtual DbSet<TasksAbc> TasksAbcs { get; set; } = null!;
        public virtual DbSet<TasksAbcanswer> TasksAbcanswers { get; set; } = null!;
        public virtual DbSet<TasksGap> TasksGaps { get; set; } = null!;
        public virtual DbSet<TasksGapsCorrectAnswer> TasksGapsCorrectAnswers { get; set; } = null!;
        public virtual DbSet<TasksGapsPossibleAnswer> TasksGapsPossibleAnswers { get; set; } = null!;
        public virtual DbSet<TasksGapsZabc> TasksGapsZabcs { get; set; } = null!;
        public virtual DbSet<TasksGapsZabccorrectAnswer> TasksGapsZabccorrectAnswers { get; set; } = null!;
        public virtual DbSet<TasksGapsZabcpack> TasksGapsZabcpacks { get; set; } = null!;
        public virtual DbSet<TasksGapsZabcpossibleAnswer> TasksGapsZabcpossibleAnswers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-VJR295T;Database=EnglishDB;Trusted_Connection=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AudioTasksGap>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Explanation)
                    .IsUnicode(false)
                    .HasColumnName("explanation");

                entity.Property(e => e.SoundtrackName)
                    .IsUnicode(false)
                    .HasColumnName("soundtrackName");

                entity.Property(e => e.TaskName)
                    .IsUnicode(false)
                    .HasColumnName("taskName");
            });

            modelBuilder.Entity<AudioTasksGapsCorrectAnswer>(entity =>
            {
                entity.ToTable("AudioTasksGapsCorrectAnswer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer1)
                    .IsUnicode(false)
                    .HasColumnName("answer1");

                entity.Property(e => e.Answer1Pl)
                    .IsUnicode(false)
                    .HasColumnName("answer1PL");

                entity.Property(e => e.Answer2)
                    .IsUnicode(false)
                    .HasColumnName("answer2");

                entity.Property(e => e.Answer2Pl)
                    .IsUnicode(false)
                    .HasColumnName("answer2PL");

                entity.Property(e => e.Answer3)
                    .IsUnicode(false)
                    .HasColumnName("answer3");

                entity.Property(e => e.Answer3Pl)
                    .IsUnicode(false)
                    .HasColumnName("answer3PL");

                entity.Property(e => e.Answer4)
                    .IsUnicode(false)
                    .HasColumnName("answer4");

                entity.Property(e => e.Answer4Pl)
                    .IsUnicode(false)
                    .HasColumnName("answer4PL");

                entity.Property(e => e.IdAudioTask).HasColumnName("idAudioTask");

                entity.HasOne(d => d.IdAudioTaskNavigation)
                    .WithMany(p => p.AudioTasksGapsCorrectAnswers)
                    .HasForeignKey(d => d.IdAudioTask)
                    .HasConstraintName("FK_AudioTaskCorrectAnswer_AudioTask");
            });

            modelBuilder.Entity<DialogueTasksGap>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Explanation)
                    .IsUnicode(false)
                    .HasColumnName("explanation");

                entity.Property(e => e.TaskName)
                    .IsUnicode(false)
                    .HasColumnName("taskName");

                entity.Property(e => e.TextToFill)
                    .IsUnicode(false)
                    .HasColumnName("textToFill");
            });

            modelBuilder.Entity<DialogueTasksGapsCorrectAnswer>(entity =>
            {
                entity.ToTable("DialogueTasksGapsCorrectAnswer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CorrectAnswer)
                    .IsUnicode(false)
                    .HasColumnName("correctAnswer");

                entity.Property(e => e.CorrectAnswerPl)
                    .IsUnicode(false)
                    .HasColumnName("correctAnswerPl");

                entity.Property(e => e.IdDialogueTasksGaps).HasColumnName("idDialogueTasksGaps");

                entity.HasOne(d => d.IdDialogueTasksGapsNavigation)
                    .WithMany(p => p.DialogueTasksGapsCorrectAnswers)
                    .HasForeignKey(d => d.IdDialogueTasksGaps)
                    .HasConstraintName("FK_DialogueTasksGapsCorrectAnswer_DialogueTasksGaps1");
            });

            modelBuilder.Entity<TasksAbc>(entity =>
            {
                entity.ToTable("TasksABC");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TaskName)
                    .IsUnicode(false)
                    .HasColumnName("taskName");
            });

            modelBuilder.Entity<TasksAbcanswer>(entity =>
            {
                entity.ToTable("TasksABCAnswer");

                entity.HasIndex(e => e.IdTasksAbc, "IX_TasksABCAnswer_idTasksABC");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CorrectAnswer)
                    .IsUnicode(false)
                    .HasColumnName("correctAnswer");

                entity.Property(e => e.Explanation)
                    .IsUnicode(false)
                    .HasColumnName("explanation");

                entity.Property(e => e.IdTasksAbc).HasColumnName("idTasksABC");

                entity.Property(e => e.Option1)
                    .IsUnicode(false)
                    .HasColumnName("option1");

                entity.Property(e => e.Option1Pl)
                    .IsUnicode(false)
                    .HasColumnName("option1PL");

                entity.Property(e => e.Option2)
                    .IsUnicode(false)
                    .HasColumnName("option2");

                entity.Property(e => e.Option2Pl)
                    .IsUnicode(false)
                    .HasColumnName("option2PL");

                entity.Property(e => e.Option3)
                    .IsUnicode(false)
                    .HasColumnName("option3");

                entity.Property(e => e.Option3Pl)
                    .IsUnicode(false)
                    .HasColumnName("option3PL");

                entity.Property(e => e.Question)
                    .IsUnicode(false)
                    .HasColumnName("question");

                entity.HasOne(d => d.IdTasksAbcNavigation)
                    .WithMany(p => p.TasksAbcanswers)
                    .HasForeignKey(d => d.IdTasksAbc)
                    .HasConstraintName("FK_TasksABCAnswer_TasksABC");
            });

            modelBuilder.Entity<TasksGap>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Explanation)
                    .IsUnicode(false)
                    .HasColumnName("explanation");

                entity.Property(e => e.TaskName)
                    .IsUnicode(false)
                    .HasColumnName("taskName");

                entity.Property(e => e.TextToFill)
                    .IsUnicode(false)
                    .HasColumnName("textToFill");
            });

            modelBuilder.Entity<TasksGapsCorrectAnswer>(entity =>
            {
                entity.ToTable("TasksGapsCorrectAnswer");

                entity.HasIndex(e => e.IdTasksGaps, "IX_TasksGapsCorrectAnswer_idTasksGaps");

                entity.HasIndex(e => e.IdTasksPossibleAnswer, "IX_TasksGapsCorrectAnswer_idTasksPossibleAnswer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdTasksGaps).HasColumnName("idTasksGaps");

                entity.Property(e => e.IdTasksPossibleAnswer).HasColumnName("idTasksPossibleAnswer");

                entity.Property(e => e.Number)
                    .IsUnicode(false)
                    .HasColumnName("number");

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
                entity.ToTable("TasksGapsPossibleAnswer");

                entity.HasIndex(e => e.IdTasksGaps, "IX_TasksGapsPossibleAnswer_idTasksGaps");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdTasksGaps).HasColumnName("idTasksGaps");

                entity.Property(e => e.PossibleAnswer)
                    .IsUnicode(false)
                    .HasColumnName("possibleAnswer");

                entity.Property(e => e.PossibleAnswerPl)
                    .IsUnicode(false)
                    .HasColumnName("possibleAnswerPL");

                entity.HasOne(d => d.IdTasksGapsNavigation)
                    .WithMany(p => p.TasksGapsPossibleAnswers)
                    .HasForeignKey(d => d.IdTasksGaps)
                    .HasConstraintName("FK_TasksPossibleAnswer_TasksGaps");
            });

            modelBuilder.Entity<TasksGapsZabc>(entity =>
            {
                entity.ToTable("TasksGapsZABC");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Explanation)
                    .IsUnicode(false)
                    .HasColumnName("explanation");

                entity.Property(e => e.TaskName)
                    .IsUnicode(false)
                    .HasColumnName("taskName");

                entity.Property(e => e.TextToFill)
                    .IsUnicode(false)
                    .HasColumnName("textToFill");
            });

            modelBuilder.Entity<TasksGapsZabccorrectAnswer>(entity =>
            {
                entity.ToTable("TasksGapsZABCCorrectAnswer");

                entity.HasIndex(e => e.IdTasksGapsAbcpossibleAnswer, "IX_TasksGapsZABCCorrectAnswer_idTasksGapsABCPossibleAnswer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdTasksGapsAbc).HasColumnName("idTasksGapsABC");

                entity.Property(e => e.IdTasksGapsAbcpossibleAnswer).HasColumnName("idTasksGapsABCPossibleAnswer");

                entity.Property(e => e.Number)
                    .IsUnicode(false)
                    .HasColumnName("number");

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
                entity.ToTable("TasksGapsZABCPack");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abcnumber)
                    .IsUnicode(false)
                    .HasColumnName("ABCnumber");
            });

            modelBuilder.Entity<TasksGapsZabcpossibleAnswer>(entity =>
            {
                entity.ToTable("TasksGapsZABCPossibleAnswer");

                entity.HasIndex(e => e.IdTasksGapsAbc, "IX_TasksGapsZABCPossibleAnswer_idTasksGapsABC");

                entity.HasIndex(e => e.IdTasksGapsAbcpack, "IX_TasksGapsZABCPossibleAnswer_idTasksGapsABCPack");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdTasksGapsAbc).HasColumnName("idTasksGapsABC");

                entity.Property(e => e.IdTasksGapsAbcpack).HasColumnName("idTasksGapsABCPack");

                entity.Property(e => e.PossibleAnswer)
                    .IsUnicode(false)
                    .HasColumnName("possibleAnswer");

                entity.Property(e => e.PossibleAnswerPl)
                    .IsUnicode(false)
                    .HasColumnName("possibleAnswerPL");

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
