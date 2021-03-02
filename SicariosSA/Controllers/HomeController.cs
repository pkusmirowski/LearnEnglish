using Microsoft.AspNetCore.Mvc;
using SicariosSA.Functions;
using SicariosSA.Models;
using SicariosSA.Services;
using System.Diagnostics;

namespace SicariosSA.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskService _taskService;

        public HomeController(TaskService taskService)
        {
            _taskService = taskService;
        }

        public IActionResult Index(string answer)
        {
            var vm = _taskService.GetTaskABC();
            if (_taskService.TaskABCCheckAnswer(vm, answer) == 1)
            {
                ViewBag.Success = true;
            }
            else if (_taskService.TaskABCCheckAnswer(vm, answer) == 2)
            {
                ViewBag.False = false;
            }
            else
            {
                ViewBag.Standard = true;
            }

            return View(vm);
        }

        public IActionResult RandomTask()
        {
            int randomTask = MathFunctions.RandomNumber(0, 2);

            if (randomTask == 0)
            {
                return RedirectToAction("Index");
            }
            else if (randomTask == 1)
            {
                return RedirectToAction("TaskGaps");
            }
            return View();
        }

        public IActionResult TaskGaps(string[] answer, string[] answerText)
        {
            var vm = _taskService.GetTaskGaps();

            if (_taskService.TaskGapsCheckAnswer(vm, answer, answerText) == 1)
            {
                ViewBag.Success = true;
            }
            else if (_taskService.TaskGapsCheckAnswer(vm, answer, answerText) == 2)
            {
                ViewBag.False = false;
            }
            else
            {
                ViewBag.Standard = true;
            }

            return View(vm);
        }

        public IActionResult TaskGapsABC(string[] answer)
        {
            var vm = _taskService.GetTaskGapsABC();

            if (_taskService.TaskGapsABCCheckAnswer(vm, answer) == 1)
            {
                ViewBag.Success = true;
            }
            else if (_taskService.TaskGapsABCCheckAnswer(vm, answer) == 2)
            {
                ViewBag.False = false;
            }
            else
            {
                ViewBag.Standard = true;
            }

            return View(vm);
        }

        public IActionResult AudioTaskGaps(string[] answer)
        {
            var vm = _taskService.GetAudioTaskGapsABC();

            if (_taskService.TaskAudioGapsCheckAnswer(vm, answer) == 1)
            {
                ViewBag.Success = true;
            }
            else if (_taskService.TaskAudioGapsCheckAnswer(vm, answer) == 2)
            {
                ViewBag.False = false;
            }
            else
            {
                ViewBag.Standard = true;
            }

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}