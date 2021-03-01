using SicariosSA.Models;
using System.Collections.Generic;

namespace SicariosSA.ViewModels
{
    public class TasksGapsABCItemViewModel
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TextToFill { get; set; }
        public string Explanation { get; set; }
        public List<TasksGapsZabcpossibleAnswer> PossibleAnswer { get; set; }
    }
}
