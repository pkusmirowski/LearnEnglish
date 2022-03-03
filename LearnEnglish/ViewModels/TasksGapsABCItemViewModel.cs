using LearnEnglish.Models;

namespace LearnEnglish.ViewModels
{
    public class TasksGapsABCItemViewModel
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TextToFill { get; set; }
        public string Explanation { get; set; }
        public List<TasksGapsZabcpossibleAnswer> PossibleAnswer { get; set; }

    }
}
