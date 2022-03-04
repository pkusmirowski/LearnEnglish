using System;
using System.Collections.Generic;

namespace LearnEnglish.Models
{
    public partial class TasksGapsZabcpossibleAnswer
    {
        public TasksGapsZabcpossibleAnswer()
        {
            TasksGapsZabccorrectAnswers = new HashSet<TasksGapsZabccorrectAnswer>();
        }

        public int Id { get; set; }
        public int? IdTasksGapsAbc { get; set; }
        public int? IdTasksGapsAbcpack { get; set; }
        public string? PossibleAnswer { get; set; }
        public string? PossibleAnswerPl { get; set; }

        public virtual TasksGapsZabc? IdTasksGapsAbcNavigation { get; set; }
        public virtual TasksGapsZabcpack? IdTasksGapsAbcpackNavigation { get; set; }
        public virtual ICollection<TasksGapsZabccorrectAnswer> TasksGapsZabccorrectAnswers { get; set; }
    }
}
