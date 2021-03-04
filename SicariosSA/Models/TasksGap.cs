using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SicariosSA.Models
{
    public partial class TasksGap
    {
        public TasksGap()
        {
            TasksGapsCorrectAnswers = new HashSet<TasksGapsCorrectAnswer>();
            TasksGapsPossibleAnswers = new HashSet<TasksGapsPossibleAnswer>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("taskName")]
        public string TaskName { get; set; }
        [Column("explanation")]
        public string Explanation { get; set; }
        [Column("textToFill")]
        public string TextToFill { get; set; }

        [InverseProperty(nameof(TasksGapsCorrectAnswer.IdTasksGapsNavigation))]
        public virtual ICollection<TasksGapsCorrectAnswer> TasksGapsCorrectAnswers { get; set; }
        [InverseProperty(nameof(TasksGapsPossibleAnswer.IdTasksGapsNavigation))]
        public virtual ICollection<TasksGapsPossibleAnswer> TasksGapsPossibleAnswers { get; set; }
    }
}
