using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SicariosSA.Models
{
    [Table("TasksGapsZABCPack")]
    public partial class TasksGapsZabcpack
    {
        public TasksGapsZabcpack()
        {
            TasksGapsZabcpossibleAnswers = new HashSet<TasksGapsZabcpossibleAnswer>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("ABCnumber", TypeName = "text")]
        public string Abcnumber { get; set; }

        [InverseProperty(nameof(TasksGapsZabcpossibleAnswer.IdTasksGapsAbcpackNavigation))]
        public virtual ICollection<TasksGapsZabcpossibleAnswer> TasksGapsZabcpossibleAnswers { get; set; }
    }
}
