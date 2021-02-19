using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SicariosSA.Models
{
    [Table("TasksABC")]
    public partial class TasksAbc
    {
        public TasksAbc()
        {
            TasksAbcanswers = new HashSet<TasksAbcanswer>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("taskName", TypeName = "text")]
        public string TaskName { get; set; }

        [InverseProperty(nameof(TasksAbcanswer.IdTasksAbcNavigation))]
        public virtual ICollection<TasksAbcanswer> TasksAbcanswers { get; set; }
    }
}
