namespace LearnEnglish.ViewModels
{
    public class TasksABCItemViewModel
    {
        public int? Id { get; set; }
        public string Question { get; set; } = null!;

        public string Option1 { get; set; } = null!;

        public string Option2 { get; set; } = null!;

        public string Option3 { get; set; } = null!;
        public string Option1Pl { get; set; } = null!;

        public string Option2Pl { get; set; } = null!;

        public string Option3Pl { get; set; } = null!;

        public string CorrectAnswer { get; set; } = null!;
        public string Explanation { get; set; } = null!;
    }
}
