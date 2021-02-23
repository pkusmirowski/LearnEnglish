using SicariosSA.Models;
using SicariosSA.ViewModels;
using System;
using System.Linq;

namespace SicariosSA.Services
{
    public class TaskService
    {
        private readonly SicariosContext _context;
        public TaskService(SicariosContext context)
        {
            _context = context;
        }

        public TasksABCViewModel GetTaskABC()
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

        public int TaskABCCheckAnswer(TasksABCViewModel viewModel, string answer)
        {
            if (answer == null)
            {
                return 0;
            }

            var currentTask = viewModel.TaskABC.FirstOrDefault();
            if (currentTask.CorrectAnswer == answer)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public TasksGapsViewModel GetTaskGaps()
        {
            var task = _context.TasksGaps.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();

            var answers = _context.TasksGapsPossibleAnswers.Where(x => x.IdTasksGaps == task.Id).ToList();

            var taskGaps = _context.TasksGaps.Select(x => new TasksGapsItemViewModel
            {
                Id = x.Id,
                TaskName = x.TaskName,
                TextToFill = x.TextToFill,
                Explanation = x.Explanation,
                PossibleAnswer = answers,
            }).Where(x => x.Id == task.Id);

            return new TasksGapsViewModel
            {
                TaskGaps = taskGaps
            };
        }

        public int TaskGapsCheckAnswer(TasksGapsViewModel viewModel, string[] answer, string[] answerText)
        {

            if (answer == null || answer.Length == 0 || answerText == null || answerText.Length == 0)
            {
                return 0;
            }

            var currentTask = viewModel.TaskGaps.FirstOrDefault();

            var answers = _context.TasksGapsCorrectAnswers.Where(x => x.IdTasksGaps == currentTask.Id).ToList();

            int counter = 0;

            bool[] correctAnswers = new bool[answer.Length];

            foreach (var an in answers)
            {
                correctAnswers[counter] = an.Number == answer[counter];
                counter++;
            }
            var numCorrectAnswers = _context.TasksGapsCorrectAnswers.Where(x => x.IdTasksGaps == currentTask.Id).Count();

            if (correctAnswers.Count(c => c) == numCorrectAnswers)
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