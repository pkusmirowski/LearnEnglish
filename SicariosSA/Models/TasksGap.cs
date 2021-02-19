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
            TasksGapsPossibleAnswers = new HashSet<TasksGapsPossibleAnswer>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("taskName", TypeName = "text")]
        public string TaskName { get; set; }
        [Column("explanation", TypeName = "text")]
        public string Explanation { get; set; }
        [Column("textToFill", TypeName = "text")]
        public string TextToFill { get; set; }

        [InverseProperty(nameof(TasksGapsPossibleAnswer.IdTasksGapsNavigation))]
        public virtual ICollection<TasksGapsPossibleAnswer> TasksGapsPossibleAnswers { get; set; }
    }
}
