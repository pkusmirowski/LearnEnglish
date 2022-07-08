namespace LearnEnglish.Models
{
    public partial class AudioTasksGapsCorrectAnswer
    {
        public int Id { get; set; }
        public string Answer1 { get; set; } = null!;
        public string Answer2 { get; set; } = null!;
        public string Answer3 { get; set; } = null!;
        public string Answer4 { get; set; } = null!;
        public string Answer1Pl { get; set; } = null!;
        public string Answer2Pl { get; set; } = null!;
        public string Answer3Pl { get; set; } = null!;
        public string Answer4Pl { get; set; } = null!;
        public int IdAudioTask { get; set; }

        public virtual AudioTasksGap? IdAudioTaskNavigation { get; set; }
    }
}
