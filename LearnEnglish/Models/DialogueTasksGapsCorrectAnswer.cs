namespace LearnEnglish.Models
{
    public partial class DialogueTasksGapsCorrectAnswer
    {
        public DialogueTasksGapsCorrectAnswer()
        {
            DialogueTasksGapsAnswerPacks = new HashSet<DialogueTasksGapsAnswerPack>();
        }

        public int Id { get; set; }
        public int? IdDialogueTasksGapsAnswerPack { get; set; }
        public string? CorrectAnswer { get; set; }
        public int? IdDialogueTasksGaps { get; set; }
        public string? CorrectAnswerPl { get; set; }

        public virtual DialogueTasksGap? IdDialogueTasksGapsNavigation { get; set; }
        public virtual ICollection<DialogueTasksGapsAnswerPack> DialogueTasksGapsAnswerPacks { get; set; }
    }
}
