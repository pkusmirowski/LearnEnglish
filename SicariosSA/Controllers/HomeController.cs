using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SicariosSA.Models;
using SicariosSA.Services;
using System.Diagnostics;
using Array = InernetVotingApplication.ExtensionMethods.ArrayExtensions;
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
            var vm = _taskService.GetABCTask();
            if (_taskService.checkAnswer(vm, answer) == 1)
            {
                ViewBag.Success = true;
            }
            else if(_taskService.checkAnswer(vm, answer) == 2)
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
