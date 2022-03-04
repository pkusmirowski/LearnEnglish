namespace LearnEnglish.Models
{
    public partial class DialogueTasksGapsCorrectAnswer
    {
        public int Id { get; set; }
        public string? CorrectAnswer { get; set; }
        public int? IdDialogueTasksGaps { get; set; }
        public string? CorrectAnswerPl { get; set; }
        public int? GapNumber { get; set; }

        public virtual DialogueTasksGap? IdDialogueTasksGapsNavigation { get; set; }
    }
}
