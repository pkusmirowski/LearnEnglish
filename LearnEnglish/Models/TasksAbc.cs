namespace LearnEnglish.Models
{
    public partial class TasksAbc
    {
        public TasksAbc()
        {
            TasksAbcanswers = new HashSet<TasksAbcanswer>();
        }

        public int Id { get; set; }
        public string? TaskName { get; set; }

        public virtual ICollection<TasksAbcanswer> TasksAbcanswers { get; set; }
    }
}
