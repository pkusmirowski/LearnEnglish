namespace LearnEnglish.Models
{
    public partial class AudioTasksGap
    {
        public AudioTasksGap()
        {
            AudioTasksGapsCorrectAnswers = new HashSet<AudioTasksGapsCorrectAnswer>();
        }

        public int Id { get; set; }
        public string TaskName { get; set; } = null!;
        public string Explanation { get; set; } = null!;
        public string SoundtrackName { get; set; } = null!;

        public virtual ICollection<AudioTasksGapsCorrectAnswer> AudioTasksGapsCorrectAnswers { get; set; }
    }
}
