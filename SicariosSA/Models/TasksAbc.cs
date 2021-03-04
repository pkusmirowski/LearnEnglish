using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column("taskName")]
        public string TaskName { get; set; }

        [InverseProperty(nameof(TasksAbcanswer.IdTasksAbcNavigation))]
        public virtual ICollection<TasksAbcanswer> TasksAbcanswers { get; set; }
    }
}
