namespace LearnEnglish.ViewModels
{
    public class AudioTasksGapsItemViewModel
    {
        public int? Id { get; set; }
        public string TaskName { get; set; } = null!;

        public string Answer1 { get; set; } = null!;

        public string Answer2 { get; set; } = null!;

        public string Answer3 { get; set; } = null!;

        public string Answer4 { get; set; } = null!;
        public string Answer1Pl { get; set; } = null!;

        public string Answer2Pl { get; set; } = null!;

        public string Answer3Pl { get; set; } = null!;

        public string Answer4Pl { get; set; } = null!;

        public string SoundtrackName { get; set; } = null!;
        public string Explanation { get; set; } = null!;
    }
}
