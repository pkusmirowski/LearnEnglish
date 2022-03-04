using System;
using System.Collections.Generic;

namespace LearnEnglish.Models
{
    public partial class TasksGapsPossibleAnswer
    {
        public TasksGapsPossibleAnswer()
        {
            TasksGapsCorrectAnswers = new HashSet<TasksGapsCorrectAnswer>();
        }

        public int Id { get; set; }
        public int? IdTasksGaps { get; set; }
        public string? PossibleAnswer { get; set; }
        public string? PossibleAnswerPl { get; set; }

        public virtual TasksGap? IdTasksGapsNavigation { get; set; }
        public virtual ICollection<TasksGapsCorrectAnswer> TasksGapsCorrectAnswers { get; set; }
    }
}
