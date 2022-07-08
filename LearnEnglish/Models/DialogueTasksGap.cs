namespace LearnEnglish.Models
{
    public partial class DialogueTasksGap
    {
        public DialogueTasksGap()
        {
            DialogueTasksGapsCorrectAnswers = new HashSet<DialogueTasksGapsCorrectAnswer>();
        }

        public int Id { get; set; }
        public string TaskName { get; set; } = null!;
        public string Explanation { get; set; } = null!;
        public string TextToFill { get; set; } = null!;

        public virtual ICollection<DialogueTasksGapsCorrectAnswer> DialogueTasksGapsCorrectAnswers { get; set; }
    }
}
