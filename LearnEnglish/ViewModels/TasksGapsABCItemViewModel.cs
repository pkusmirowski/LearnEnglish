using LearnEnglish.Models;

namespace LearnEnglish.ViewModels
{
    public class TasksGapsABCItemViewModel
    {
        public int Id { get; set; }
        public string TaskName { get; set; } = null!;
        public string TextToFill { get; set; } = null!;
        public string Explanation { get; set; } = null!;
        public List<TasksGapsZabcpossibleAnswer> PossibleAnswer { get; set; } = null!;

    }
}
