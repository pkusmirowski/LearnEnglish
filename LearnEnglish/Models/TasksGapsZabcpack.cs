using System;
using System.Collections.Generic;

namespace LearnEnglish.Models
{
    public partial class TasksGapsZabcpack
    {
        public TasksGapsZabcpack()
        {
            TasksGapsZabcpossibleAnswers = new HashSet<TasksGapsZabcpossibleAnswer>();
        }

        public int Id { get; set; }
        public string? Abcnumber { get; set; }

        public virtual ICollection<TasksGapsZabcpossibleAnswer> TasksGapsZabcpossibleAnswers { get; set; }
    }
}
