namespace SicariosSA.ViewModels
{
    public class TasksABCItemViewModel
    {
        public int? Id { get; set; }
        public string Question { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }
        public string Option1Pl { get; set; }

        public string Option2Pl { get; set; }

        public string Option3Pl { get; set; }

        public string CorrectAnswer { get; set; }
        public string Explanation { get; set; }
    }
}
