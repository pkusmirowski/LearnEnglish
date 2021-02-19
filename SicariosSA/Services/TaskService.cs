using SicariosSA.Models;
using SicariosSA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SicariosSA.Services
{
    public class TaskService
    {
        private readonly SicariosContext _context;
        public TaskService(SicariosContext context)
        {
            _context = context;
        }

        public TasksABCViewModel GetABCTask()
        {
            var result = _context.TasksAbcs.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();

            var taskABC = _context.TasksAbcanswers.Select(x => new TasksABCItemViewModel
            {
                Id = x.IdTasksAbc,
                Option1 = x.Option1,
                Option2 = x.Option2,
                Option3 = x.Option3,
                Option1Pl = x.Option1Pl,
                Option2Pl = x.Option2Pl,
                Option3Pl = x.Option3Pl,
                Question = x.Question,
                CorrectAnswer = x.CorrectAnswer,
                Explanation = x.Explanation,
            }).Where(x => x.Id == result.Id);

            return new TasksABCViewModel
            {
                TaskABC = taskABC
            };
        }

        public int checkAnswer(TasksABCViewModel viewModel, string answer)
        {
            if (answer == null)
            {
                return 0;
            }

            var x = viewModel.TaskABC.FirstOrDefault();
            if (x.CorrectAnswer == answer)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
