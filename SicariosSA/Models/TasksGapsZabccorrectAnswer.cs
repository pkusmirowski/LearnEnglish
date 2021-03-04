using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SicariosSA.Models
{
    [Table("TasksGapsZABCCorrectAnswer")]
    [Index(nameof(IdTasksGapsAbcpossibleAnswer), Name = "IX_TasksGapsZABCCorrectAnswer_idTasksGapsABCPossibleAnswer")]
    public partial class TasksGapsZabccorrectAnswer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("number")]
        public string Number { get; set; }
        [Column("idTasksGapsABCPossibleAnswer")]
        public int? IdTasksGapsAbcpossibleAnswer { get; set; }
        [Column("idTasksGapsABC")]
        public int? IdTasksGapsAbc { get; set; }

        [ForeignKey(nameof(IdTasksGapsAbc))]
        [InverseProperty(nameof(TasksGapsZabc.TasksGapsZabccorrectAnswers))]
        public virtual TasksGapsZabc IdTasksGapsAbcNavigation { get; set; }
        [ForeignKey(nameof(IdTasksGapsAbcpossibleAnswer))]
        [InverseProperty(nameof(TasksGapsZabcpossibleAnswer.TasksGapsZabccorrectAnswers))]
        public virtual TasksGapsZabcpossibleAnswer IdTasksGapsAbcpossibleAnswerNavigation { get; set; }
    }
}
