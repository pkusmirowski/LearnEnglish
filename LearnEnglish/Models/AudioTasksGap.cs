namespace LearnEnglish.Models
{
    public partial class AudioTasksGap
    {
        public AudioTasksGap()
        {
            AudioTasksGapsCorrectAnswers = new HashSet<AudioTasksGapsCorrectAnswer>();
        }

        public int Id { get; set; }
        public string? TaskName { get; set; }
        public string? Explanation { get; set; }
        public string? SoundtrackName { get; set; }

        public virtual ICollection<AudioTasksGapsCorrectAnswer> AudioTasksGapsCorrectAnswers { get; set; }
    }
}
