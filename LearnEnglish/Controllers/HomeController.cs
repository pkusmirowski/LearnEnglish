using LearnEnglish.Functions;
using LearnEnglish.Services;
using LearnEnglish.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LearnEnglish.Controllers
{
    public class HomeController(TaskService taskService) : Controller
    {
        private readonly TaskService _taskService = taskService;

        public IActionResult Index(string answer)
        {
            var vm = _taskService.GetTaskABC();
            SetViewBagForTaskABC(vm, answer);
            return View(vm);
        }

        public IActionResult RandomTask()
        {
            int randomTask = MathFunctions.RandomNumber(0, 4);

            return randomTask switch
            {
                0 => RedirectToAction("Index"),
                1 => RedirectToAction("TaskGaps"),
                2 => RedirectToAction("TaskGapsABC"),
                3 => RedirectToAction("DialogueTaskGaps"),
                _ => View()
            };
        }

        public IActionResult TaskGaps(string[] answer, string[] answerText)
        {
            var vm = _taskService.GetTaskGaps();
            SetViewBagForTaskGaps(vm, answer, answerText);
            return View(vm);
        }

        public IActionResult TaskGapsABC(string[] answer)
        {
            var vm = _taskService.GetTaskGapsABC();
            SetViewBagForTaskGapsABC(vm, answer);
            return View(vm);
        }

        public IActionResult AudioTaskGaps(string[] answer)
        {
            var vm = _taskService.GetAudioTaskGapsABC();
            SetViewBagForAudioTaskGaps(vm, answer);
            return View(vm);
        }

        public IActionResult DialogueTaskGaps(string[] answer)
        {
            var vm = _taskService.GetDialogueTasksGaps();
            SetViewBagForDialogueTaskGaps(vm, answer);
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }

        private void SetViewBagForTaskABC(TasksABCViewModel vm, string answer)
        {
            var result = _taskService.TaskABCCheckAnswer(vm, answer);
            if (result == 1)
            {
                ViewBag.GoodA = answer;
                ViewBag.Success = true;
            }
            else if (result == 2)
            {
                ViewBag.GoodA = _taskService.TaskABCGetCorrectAnswer(vm);
                ViewBag.BadA = answer;
                ViewBag.False = false;
            }
            else
            {
                ViewBag.Standard = true;
            }
        }

        private void SetViewBagForTaskGaps(TasksGapsViewModel vm, string[] answer, string[] answerText)
        {
            var result = _taskService.TaskGapsCheckAnswer(vm, answer, answerText);
            if (result == 1)
            {
                var correctAnswers = _taskService.GetCorrectAnswersTaskGaps(vm, answer, answerText);
                ViewBag.correctAnswers = correctAnswers;
                ViewBag.AnswerG = answer;
                ViewBag.Success = true;
            }
            else if (result == 2)
            {
                var correctAnswers = _taskService.GetCorrectAnswersTaskGaps(vm, answer, answerText);
                ViewBag.AnswerB = correctAnswers;
                ViewBag.False = false;
            }
            else
            {
                ViewBag.Standard = true;
            }
        }

        private void SetViewBagForTaskGapsABC(TasksGapsABCViewModel vm, string[] answer)
        {
            var result = _taskService.TaskGapsABCCheckAnswer(vm, answer);
            if (result == 1)
            {
                ViewBag.AnswerG = answer;
                ViewBag.Success = true;
            }
            else if (result == 2)
            {
                ViewBag.AnswerB = answer;
                ViewBag.False = false;
            }
            else
            {
                ViewBag.Standard = true;
            }
        }

        private void SetViewBagForAudioTaskGaps(AudioTasksGapsViewModel vm, string[] answer)
        {
            var result = _taskService.TaskAudioGapsCheckAnswer(vm, answer);
            if (result == 1)
            {
                ViewBag.Success = true;
            }
            else if (result == 2)
            {
                ViewBag.False = false;
            }
            else
            {
                ViewBag.Standard = true;
            }
        }

        private void SetViewBagForDialogueTaskGaps(DialogueTasksGapsViewModel vm, string[] answer)
        {
            var result = _taskService.DialogueTaskGapsCheckAnswer(vm, answer);
            if (result == 1)
            {
                ViewBag.AnswerG = answer;
                ViewBag.Count = answer.Length;
                ViewBag.Success = true;
            }
            else if (result == 2)
            {
                ViewBag.AnswerB = answer;
                ViewBag.Count = answer.Length;
                ViewBag.False = false;
            }
            else
            {
                ViewBag.Standard = true;
            }
        }
    }
}