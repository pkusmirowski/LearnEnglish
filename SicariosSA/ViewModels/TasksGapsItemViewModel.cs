using SicariosSA.Models;
using System.Collections.Generic;

namespace SicariosSA.ViewModels
{
    public class TasksGapsItemViewModel
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TextToFill { get; set; }
        public string Explanation { get; set; }
        public List<TasksGapsPossibleAnswer> PossibleAnswer { get; set; }
    }
}
