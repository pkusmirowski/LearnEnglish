namespace LearnEnglish.Models
{
    public partial class DialogueTasksGapsAnswerPack
    {
        public int Id { get; set; }
        public int? IdDialogueTasksGaps { get; set; }
        public string? AnswerNumber { get; set; }

        public virtual DialogueTasksGapsCorrectAnswer? IdDialogueTasksGaps1 { get; set; }
        public virtual DialogueTasksGap? IdDialogueTasksGapsNavigation { get; set; }
    }
}
