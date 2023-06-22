using LearnEnglish.Models;
using LearnEnglish.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace LearnEnglish.Services
{
    public class TaskService
    {
        private readonly EnglishDBContext _context;
        public TaskService(EnglishDBContext context)
        {
            _context = context;
        }

        public TasksABCViewModel GetTaskABC()
        {
            var result = _context.TasksAbcs.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
            if (result == null)
            {
                return new TasksABCViewModel();
            }

            var taskABC = _context.TasksAbcanswers
                .Where(x => x.IdTasksAbc == result.Id)
                .Select(x => new TasksABCItemViewModel
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
                })
                .ToList();

            return new TasksABCViewModel
            {
                TaskABC = taskABC
            };
        }

        public string TaskABCGetCorrectAnswer(TasksABCViewModel viewModel)
        {
            var currentTask = viewModel.TaskABC.FirstOrDefault();

            if (currentTask == null)
            {
                return "No task";
            }

            return currentTask.CorrectAnswer;
        }

        public int TaskABCCheckAnswer(TasksABCViewModel viewModel, string answer)
        {
            if (answer == null)
            {
                return 0;
            }

            var currentTask = viewModel.TaskABC.FirstOrDefault();

            if (currentTask == null)
            {
                return 0;
            }

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
            if (task == null)
            {
                return new TasksGapsViewModel();
            }

            var answers = _context.TasksGapsPossibleAnswers
                .Where(x => x.IdTasksGaps == task.Id)
                .ToList();

            var taskGaps = _context.TasksGaps
                .Where(x => x.Id == task.Id)
                .Select(x => new TasksGapsItemViewModel
                {
                    Id = x.Id,
                    TaskName = x.TaskName,
                    TextToFill = x.TextToFill,
                    Explanation = x.Explanation,
                    PossibleAnswer = answers,
                })
                .ToList();

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
                if (!string.IsNullOrEmpty(answer[i]))
                {
                    correctAnswersText[answersCounter] = answerText[i];
                    answersCounter++;
                }
            }

            var currentTask = viewModel.TaskGaps.FirstOrDefault();
            if (currentTask == null)
            {
                return 0;
            }

            var answers = _context.TasksGapsCorrectAnswers
                .Include(x => x.IdTasksPossibleAnswerNavigation)
                .Where(x => x.IdTasksGaps == currentTask.Id)
                .ToList();

            bool[] correctAnswers = new bool[answers.Count];
            int counter = 0;

            foreach (var an in answers)
            {
                correctAnswers[counter] = an.IdTasksPossibleAnswerNavigation?.PossibleAnswer == correctAnswersText[counter];
                counter++;
            }

            var numCorrectAnswers = answers.Count;

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
            if (answer == null || answer.Length == 0 || answerText == null || answerText.Length == 0)
            {
                return new List<TasksGapsCorrectAnswer>();
            }

            string[] correctAnswersText = new string[answer.Length];
            int answersCounter = 0;

            for (int i = 0; i < answer.Length; i++)
            {
                if (!string.IsNullOrEmpty(answer[i]))
                {
                    correctAnswersText[answersCounter] = answerText[i];
                    answersCounter++;
                }
            }

            var currentTask = viewModel.TaskGaps.FirstOrDefault();
            if (currentTask == null)
            {
                return new List<TasksGapsCorrectAnswer>();
            }

            var correctAnswers = _context.TasksGapsCorrectAnswers
                .Include(x => x.IdTasksPossibleAnswerNavigation)
                .Where(x => x.IdTasksGaps == currentTask.Id)
                .ToList();

            return correctAnswers;
        }

        public TasksGapsABCViewModel GetTaskGapsABC()
        {
            var task = _context.TasksGapsZabcs.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
            if (task == null)
            {
                return new TasksGapsABCViewModel();
            }

            var taskGaps = _context.TasksGapsZabcs
                .Include(x => x.TasksGapsZabcpossibleAnswers)
                .Where(x => x.Id == task.Id)
                .Select(x => new TasksGapsABCItemViewModel
                {
                    Id = x.Id,
                    TaskName = x.TaskName,
                    TextToFill = x.TextToFill,
                    Explanation = x.Explanation,
                    PossibleAnswer = x.TasksGapsZabcpossibleAnswers.ToList(),
                })
                .FirstOrDefault();

            return new TasksGapsABCViewModel
            {
                TaskGapsABC = taskGaps != null ? new List<TasksGapsABCItemViewModel> { taskGaps } : new List<TasksGapsABCItemViewModel>()
            };
        }

        public int TaskGapsABCCheckAnswer(TasksGapsABCViewModel viewModel, string[] answer)
        {
            if (answer == null || answer.Length == 0)
            {
                return 0;
            }

            var currentTask = viewModel.TaskGapsABC.FirstOrDefault();
            if (currentTask == null)
            {
                return 0;
            }

            var correctAnswers = _context.TasksGapsZabccorrectAnswers
                .Where(x => x.IdTasksGapsAbc == currentTask.Id)
                .Select(x => x.IdTasksGapsAbcpossibleAnswerNavigation.PossibleAnswer)
                .ToList();

            bool[] isAnswerCorrect = new bool[answer.Length];

            for (int i = 0; i < answer.Length; i++)
            {
                if (i < correctAnswers.Count)
                {
                    isAnswerCorrect[i] = correctAnswers[i] == answer[i];
                }
                else
                {
                    break;
                }
            }

            var numCorrectAnswers = correctAnswers.Count;

            if (isAnswerCorrect.Count(c => c) == numCorrectAnswers)
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

            if (task == null)
            {
                return new AudioTasksGapsViewModel();
            }

            var taskGaps = _context.AudioTasksGapsCorrectAnswers
                .Where(x => x.IdAudioTask == task.Id)
                .Select(x => new AudioTasksGapsItemViewModel
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
                })
                .ToList();

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
            if (currentTask == null)
            {
                return 0;
            }

            bool isCorrect = currentTask.Answer1 == answer[0] &&
                             currentTask.Answer2 == answer[1] &&
                             currentTask.Answer3 == answer[2] &&
                             currentTask.Answer4 == answer[3];

            return isCorrect ? 1 : 2;
        }

        public DialogueTasksGapsViewModel GetDialogueTasksGaps()
        {
            var task = _context.DialogueTasksGaps.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
            if (task == null)
            {
                return new DialogueTasksGapsViewModel();
            }

            var taskGaps = _context.DialogueTasksGaps
                .Where(x => x.Id == task.Id)
                .Select(x => new DialogueTasksGapsItemViewModel
                {
                    Id = x.Id,
                    TaskName = x.TaskName,
                    TextToFill = x.TextToFill,
                    Explanation = x.Explanation,
                    CorrectAnswers = _context.DialogueTasksGapsCorrectAnswers
                        .Where(a => a.IdDialogueTasksGaps == x.Id)
                        .ToList()
                })
                .ToList();

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

            if (currentTask == null)
            {
                return 0;
            }

            var answers = _context.DialogueTasksGapsCorrectAnswers
                .Where(x => x.IdDialogueTasksGaps == currentTask.Id)
                .ToList();

            var boolList = new List<bool>();

            for (int i = 0; i < answers.Count; i++)
            {
                var an = answers[i];
                if (an.CorrectAnswer == answer[i] && an.GapNumber == i + 1)
                {
                    boolList.Add(true);
                }
                else
                {
                    boolList.Add(false);
                }
            }

            if (boolList.All(c => c))
            {
                return 1;
            }
            else if (boolList.Any(c => !c))
            {
                return 2;
            }

            return 0;
        }
    }
}