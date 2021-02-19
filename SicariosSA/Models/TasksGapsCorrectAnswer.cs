using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

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
        [StringLength(50)]
        public string Number { get; set; }
        [Column("idTasksPossibleAnswer")]
        public int? IdTasksPossibleAnswer { get; set; }

        [ForeignKey(nameof(IdTasksPossibleAnswer))]
        [InverseProperty(nameof(TasksGapsPossibleAnswer.TasksGapsCorrectAnswers))]
        public virtual TasksGapsPossibleAnswer IdTasksPossibleAnswerNavigation { get; set; }
    }
}
