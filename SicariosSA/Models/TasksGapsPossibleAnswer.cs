using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SicariosSA.Models
{
    [Table("TasksGapsPossibleAnswer")]
    public partial class TasksGapsPossibleAnswer
    {
        public TasksGapsPossibleAnswer()
        {
            TasksGapsCorrectAnswers = new HashSet<TasksGapsCorrectAnswer>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idTasksGaps")]
        public int? IdTasksGaps { get; set; }
        [Column("possibleAnswer", TypeName = "text")]
        public string PossibleAnswer { get; set; }

        [ForeignKey(nameof(IdTasksGaps))]
        [InverseProperty(nameof(TasksGap.TasksGapsPossibleAnswers))]
        public virtual TasksGap IdTasksGapsNavigation { get; set; }
        [InverseProperty(nameof(TasksGapsCorrectAnswer.IdTasksPossibleAnswerNavigation))]
        public virtual ICollection<TasksGapsCorrectAnswer> TasksGapsCorrectAnswers { get; set; }
    }
}
