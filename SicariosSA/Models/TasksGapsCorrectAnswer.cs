using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SicariosSA.Models
{
    [Table("TasksGapsCorrectAnswer")]
    public partial class TasksGapsCorrectAnswer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("number")]
        public string Number { get; set; }
        [Column("idTasksPossibleAnswer")]
        public int? IdTasksPossibleAnswer { get; set; }
        [Column("idTasksGaps")]
        public int? IdTasksGaps { get; set; }

        [ForeignKey(nameof(IdTasksGaps))]
        [InverseProperty(nameof(TasksGap.TasksGapsCorrectAnswers))]
        public virtual TasksGap IdTasksGapsNavigation { get; set; }
        [ForeignKey(nameof(IdTasksPossibleAnswer))]
        [InverseProperty(nameof(TasksGapsPossibleAnswer.TasksGapsCorrectAnswers))]
        public virtual TasksGapsPossibleAnswer IdTasksPossibleAnswerNavigation { get; set; }
    }
}
