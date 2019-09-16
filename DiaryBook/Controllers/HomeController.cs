using DiaryBook.BusinessLogic;
using DiaryBook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DiaryBook.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var logic = new DiaryBusinessLogic();
            var diaries = logic.GetDiaries();

            return View();
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
