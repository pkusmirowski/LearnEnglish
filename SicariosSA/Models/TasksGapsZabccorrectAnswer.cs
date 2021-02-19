using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SicariosSA.Models
{
    [Table("TasksGapsZABCCorrectAnswer")]
    public partial class TasksGapsZabccorrectAnswer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("number", TypeName = "text")]
        public string Number { get; set; }
        [Column("idTasksGapsABCPossibleAnswer")]
        public int? IdTasksGapsAbcpossibleAnswer { get; set; }

        [ForeignKey(nameof(IdTasksGapsAbcpossibleAnswer))]
        [InverseProperty(nameof(TasksGapsZabcpossibleAnswer.TasksGapsZabccorrectAnswers))]
        public virtual TasksGapsZabcpossibleAnswer IdTasksGapsAbcpossibleAnswerNavigation { get; set; }
    }
}
