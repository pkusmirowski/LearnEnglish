namespace LearnEnglish.Models
{
    public partial class DialogueTasksGap
    {
        public DialogueTasksGap()
        {
            DialogueTasksGapsCorrectAnswers = new HashSet<DialogueTasksGapsCorrectAnswer>();
        }

        public int Id { get; set; }
        public string? TaskName { get; set; }
        public string? Explanation { get; set; }
        public string? TextToFill { get; set; }

        public virtual ICollection<DialogueTasksGapsCorrectAnswer> DialogueTasksGapsCorrectAnswers { get; set; }
    }
}
