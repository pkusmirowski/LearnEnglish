namespace LearnEnglish.Models
{
    public partial class TasksGapsZabc
    {
        public TasksGapsZabc()
        {
            TasksGapsZabccorrectAnswers = new HashSet<TasksGapsZabccorrectAnswer>();
            TasksGapsZabcpossibleAnswers = new HashSet<TasksGapsZabcpossibleAnswer>();
        }

        public int Id { get; set; }
        public string? TaskName { get; set; }
        public string? Explanation { get; set; }
        public string? TextToFill { get; set; }

        public virtual ICollection<TasksGapsZabccorrectAnswer> TasksGapsZabccorrectAnswers { get; set; }
        public virtual ICollection<TasksGapsZabcpossibleAnswer> TasksGapsZabcpossibleAnswers { get; set; }
    }
}
