namespace LearnEnglish.Models
{
    public partial class TasksGapsCorrectAnswer
    {
        public int Id { get; set; }
        public string? Number { get; set; }
        public int? IdTasksPossibleAnswer { get; set; }
        public int? IdTasksGaps { get; set; }

        public virtual TasksGap? IdTasksGapsNavigation { get; set; }
        public virtual TasksGapsPossibleAnswer? IdTasksPossibleAnswerNavigation { get; set; }
    }
}
