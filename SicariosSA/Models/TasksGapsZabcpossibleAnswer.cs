using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SicariosSA.Models
{
    [Table("TasksGapsZABCPossibleAnswer")]
    public partial class TasksGapsZabcpossibleAnswer
    {
        public TasksGapsZabcpossibleAnswer()
        {
            TasksGapsZabccorrectAnswers = new HashSet<TasksGapsZabccorrectAnswer>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idTasksGapsABC")]
        public int? IdTasksGapsAbc { get; set; }
        [Column("idTasksGapsABCPack")]
        public int? IdTasksGapsAbcpack { get; set; }
        [Column("possibleAnswer", TypeName = "text")]
        public string PossibleAnswer { get; set; }

        [ForeignKey(nameof(IdTasksGapsAbc))]
        [InverseProperty(nameof(TasksGapsZabc.TasksGapsZabcpossibleAnswers))]
        public virtual TasksGapsZabc IdTasksGapsAbcNavigation { get; set; }
        [ForeignKey(nameof(IdTasksGapsAbcpack))]
        [InverseProperty(nameof(TasksGapsZabcpack.TasksGapsZabcpossibleAnswers))]
        public virtual TasksGapsZabcpack IdTasksGapsAbcpackNavigation { get; set; }
        [InverseProperty(nameof(TasksGapsZabccorrectAnswer.IdTasksGapsAbcpossibleAnswerNavigation))]
        public virtual ICollection<TasksGapsZabccorrectAnswer> TasksGapsZabccorrectAnswers { get; set; }
    }
}
