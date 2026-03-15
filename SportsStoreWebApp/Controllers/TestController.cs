using Microsoft.AspNetCore.Mvc;
namespace SportsStoreWebApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Chao mung ban den voi Cua hang The thao! Day la trang Test.";
            return View();
        }
        public IActionResult HelloWorld()
        {
            return Content("Xin chao tu Action HelloWorld trong TestController!");
        }
        public IActionResult Welcome(string name = "Khach")
        {
            return Content($"Xin chao {name}, chao mung ban den voi Cua hang The thao!");
        }
    }
}