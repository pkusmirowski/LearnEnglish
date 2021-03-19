using SicariosSA.Models;
using SicariosSA.ViewModels;
using System;
using System.Collections.Generic;
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

        public string TaskABCGetCorrectAnswer(TasksABCViewModel viewModel)
        {
            var currentTask = viewModel.TaskABC.FirstOrDefault();
            return currentTask.CorrectAnswer;
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

            string[] correctAnswersText = new string[answer.Length];

            int answersCounter = 0;

            for (int i = 0; i < answer.Length; i++)
            {
                if (!String.IsNullOrEmpty(answer[i]))
                {
                    correctAnswersText[answersCounter] = answerText[i];
                    answersCounter++;
                }
            }

            var currentTask = viewModel.TaskGaps.FirstOrDefault();

            var answers = _context.TasksGapsCorrectAnswers.Where(x => x.IdTasksGaps == currentTask.Id).ToList();

            int counter = 0;

            bool[] correctAnswers = new bool[answer.Length];

            foreach (var an in answers)
            {
                correctAnswers[counter] = an.IdTasksPossibleAnswerNavigation.PossibleAnswer == correctAnswersText[counter];
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

        public List<TasksGapsCorrectAnswer> GetCorrectAnswersTaskGaps(TasksGapsViewModel viewModel, string[] answer, string[] answerText)
        {
            string[] correctAnswersText = new string[answer.Length];

            int answersCounter = 0;

            for (int i = 0; i < answer.Length; i++)
            {
                if (!String.IsNullOrEmpty(answer[i]))
                {
                    correctAnswersText[answersCounter] = answerText[i];
                    answersCounter++;
                }
            }

            var currentTask = viewModel.TaskGaps.FirstOrDefault();

            return _context.TasksGapsCorrectAnswers.Where(x => x.IdTasksGaps == currentTask.Id).ToList();
        }

        public TasksGapsABCViewModel GetTaskGapsABC()
        {
            var task = _context.TasksGapsZabcs.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();

            var answers = _context.TasksGapsZabcpossibleAnswers.Where(x => x.IdTasksGapsAbc == task.Id).ToList();

            var taskGaps = _context.TasksGapsZabcs.Select(x => new TasksGapsABCItemViewModel
            {
                Id = x.Id,
                TaskName = x.TaskName,
                TextToFill = x.TextToFill,
                Explanation = x.Explanation,
                PossibleAnswer = answers,
            }).Where(x => x.Id == task.Id);

            return new TasksGapsABCViewModel
            {
                TaskGapsABC = taskGaps
            };
        }

        public int TaskGapsABCCheckAnswer(TasksGapsABCViewModel viewModel, string[] answer)
        {
            if (answer == null || answer.Length == 0)
            {
                return 0;
            }

            var currentTask = viewModel.TaskGapsABC.FirstOrDefault();

            var answers = _context.TasksGapsZabccorrectAnswers.Where(x => x.IdTasksGapsAbc == currentTask.Id).ToList();

            int counter = 0;

            bool[] correctAnswers = new bool[answer.Length];

            foreach (var an in answers)
            {
                correctAnswers[counter] = an.IdTasksGapsAbcpossibleAnswerNavigation.PossibleAnswer == answer[counter];
                counter++;
            }
            var numCorrectAnswers = _context.TasksGapsZabccorrectAnswers.Where(x => x.IdTasksGapsAbc == currentTask.Id).Count();

            if (correctAnswers.Count(c => c) == numCorrectAnswers)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public AudioTasksGapsViewModel GetAudioTaskGapsABC()
        {
            var task = _context.AudioTasksGaps.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();

            var taskGaps = _context.AudioTasksGapsCorrectAnswers.Select(x => new AudioTasksGapsItemViewModel
            {
                Id = x.IdAudioTask,
                TaskName = task.TaskName,
                Answer1 = x.Answer1,
                Answer2 = x.Answer2,
                Answer3 = x.Answer3,
                Answer4 = x.Answer4,
                Answer1Pl = x.Answer1Pl,
                Answer2Pl = x.Answer2Pl,
                Answer3Pl = x.Answer3Pl,
                Answer4Pl = x.Answer4Pl,
                SoundtrackName = task.SoundtrackName,
                Explanation = task.Explanation
            }).Where(x => x.Id == task.Id);

            return new AudioTasksGapsViewModel
            {
                AudioTaskGaps = taskGaps
            };
        }

        public int TaskAudioGapsCheckAnswer(AudioTasksGapsViewModel viewModel, string[] answer)
        {
            if (answer == null || answer.Length == 0)
            {
                return 0;
            }

            var currentTask = viewModel.AudioTaskGaps.FirstOrDefault();

            if (currentTask.Answer1 == answer[0] && currentTask.Answer2 == answer[1] && currentTask.Answer3 == answer[2] && currentTask.Answer4 == answer[3])
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public DialogueTasksGapsViewModel GetDialogueTasksGaps()
        {
            var task = _context.DialogueTasksGaps.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();

            var answers = _context.DialogueTasksGapsCorrectAnswers.Where(x => x.IdDialogueTasksGaps == task.Id).ToList();

            var answerNumber = _context.DialogueTasksGapsAnswerPacks.Where(x => x.IdDialogueTasksGaps == task.Id).ToList();

            var taskGaps = _context.DialogueTasksGaps.Select(x => new DialogueTasksGapsItemViewModel
            {
                Id = x.Id,
                TaskName = x.TaskName,
                TextToFill = x.TextToFill,
                Explanation = x.Explanation,
                CorrectAnswers = answers,
                AnswerNumber = answerNumber.Count,
            }).Where(x => x.Id == task.Id);

            return new DialogueTasksGapsViewModel
            {
                DialogueTaskGaps = taskGaps
            };
        }

        public int DialogueTaskGapsCheckAnswer(DialogueTasksGapsViewModel viewModel, string[] answer)
        {
            if (answer == null || answer.Length == 0)
            {
                return 0;
            }

            var currentTask = viewModel.DialogueTaskGaps.FirstOrDefault();

            var answers = _context.DialogueTasksGapsCorrectAnswers.Where(x => x.IdDialogueTasksGaps == currentTask.Id).ToList();

            var answerNumber = _context.DialogueTasksGapsAnswerPacks.Where(x => x.IdDialogueTasksGaps == currentTask.Id).ToList();

            int counter = 0;

            bool[] correctAnswers = new bool[answerNumber.Count];

            Array.Resize(ref answer, answers.Count);

            foreach (var an in answers)
            {
                for (int i = 0; i < answers.Count; i++)
                {
                    if (!String.IsNullOrEmpty(answer[counter]))
                    {
                        if (answers[i].CorrectAnswer == answer[counter])
                        {
                            correctAnswers[counter] = true;
                        }
                    }
                }
                counter++;
            }

            if (correctAnswers.Count(c => c) == answerNumber.Count)
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