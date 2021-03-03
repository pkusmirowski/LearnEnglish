using SicariosSA.Models;
using System.Collections.Generic;

namespace SicariosSA.ViewModels
{
    public class DialogueTasksGapsItemViewModel
    {
        public int? Id { get; set; }
        public string TaskName { get; set; }
        public string TextToFill { get; set; }
        public string Explanation { get; set; }

        public int AnswerNumber { get; set; }
        public List<DialogueTasksGapsCorrectAnswer> CorrectAnswers { get; set; }
    }
}
