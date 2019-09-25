using DiaryBook.Contracts.Services;
using DiaryBook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DiaryBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDiaryBookService diaryBookService;

        public HomeController(IDiaryBookService diaryBookService)
        {
            this.diaryBookService = diaryBookService;
        }

        public IActionResult Index()
        {
            var diaries = diaryBookService.GetDiaries();

            foreach (var diary in diaries)
            {
                diary.Content = "DI";
                diaryBookService.UpdateDiary(diary);
            }

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
