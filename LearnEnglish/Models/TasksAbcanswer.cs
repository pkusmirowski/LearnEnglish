using System;
using System.Collections.Generic;

namespace LearnEnglish.Models
{
    public partial class TasksAbcanswer
    {
        public int Id { get; set; }
        public string? Question { get; set; }
        public string? Option1 { get; set; }
        public string? Option2 { get; set; }
        public string? Option3 { get; set; }
        public string? Option1Pl { get; set; }
        public string? Option2Pl { get; set; }
        public string? Option3Pl { get; set; }
        public string? CorrectAnswer { get; set; }
        public int? IdTasksAbc { get; set; }
        public string? Explanation { get; set; }

        public virtual TasksAbc? IdTasksAbcNavigation { get; set; }
    }
}
