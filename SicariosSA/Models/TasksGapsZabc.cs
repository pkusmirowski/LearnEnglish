using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SicariosSA.Models
{
    [Table("TasksGapsZABC")]
    public partial class TasksGapsZabc
    {
        public TasksGapsZabc()
        {
            TasksGapsZabccorrectAnswers = new HashSet<TasksGapsZabccorrectAnswer>();
            TasksGapsZabcpossibleAnswers = new HashSet<TasksGapsZabcpossibleAnswer>();
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

        [InverseProperty(nameof(TasksGapsZabccorrectAnswer.IdTasksGapsAbcNavigation))]
        public virtual ICollection<TasksGapsZabccorrectAnswer> TasksGapsZabccorrectAnswers { get; set; }
        [InverseProperty(nameof(TasksGapsZabcpossibleAnswer.IdTasksGapsAbcNavigation))]
        public virtual ICollection<TasksGapsZabcpossibleAnswer> TasksGapsZabcpossibleAnswers { get; set; }
    }
}
