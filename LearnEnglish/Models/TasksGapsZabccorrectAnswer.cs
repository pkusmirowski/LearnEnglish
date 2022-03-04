using System;
using System.Collections.Generic;

namespace LearnEnglish.Models
{
    public partial class TasksGapsZabccorrectAnswer
    {
        public int Id { get; set; }
        public string? Number { get; set; }
        public int? IdTasksGapsAbcpossibleAnswer { get; set; }
        public int? IdTasksGapsAbc { get; set; }

        public virtual TasksGapsZabc? IdTasksGapsAbcNavigation { get; set; }
        public virtual TasksGapsZabcpossibleAnswer? IdTasksGapsAbcpossibleAnswerNavigation { get; set; }
    }
}
