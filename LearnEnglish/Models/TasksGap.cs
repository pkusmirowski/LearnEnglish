using System;
using System.Collections.Generic;

namespace LearnEnglish.Models
{
    public partial class TasksGap
    {
        public TasksGap()
        {
            TasksGapsCorrectAnswers = new HashSet<TasksGapsCorrectAnswer>();
            TasksGapsPossibleAnswers = new HashSet<TasksGapsPossibleAnswer>();
        }

        public int Id { get; set; }
        public string? TaskName { get; set; }
        public string? Explanation { get; set; }
        public string? TextToFill { get; set; }

        public virtual ICollection<TasksGapsCorrectAnswer> TasksGapsCorrectAnswers { get; set; }
        public virtual ICollection<TasksGapsPossibleAnswer> TasksGapsPossibleAnswers { get; set; }
    }
}
