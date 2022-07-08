using LearnEnglish.Models;

namespace LearnEnglish.ViewModels
{
    public class DialogueTasksGapsItemViewModel
    {
        public int? Id { get; set; }
        public string TaskName { get; set; } = null!;
        public string Explanation { get; set; } = null!;
        public string TextToFill { get; set; } = null!;

        public int AnswerNumber { get; set; }
        public List<DialogueTasksGapsCorrectAnswer> CorrectAnswers { get; set; } = null!;
    }
}