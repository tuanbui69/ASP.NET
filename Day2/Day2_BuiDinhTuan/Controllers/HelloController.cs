using Microsoft.AspNetCore.Mvc;

namespace Day2_BuiDinhTuan.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name = "Tuan", int id = 3)
        {
            ViewData["Name"] = string.IsNullOrEmpty(name) ? "Tuan" : name;
            ViewData["ID"] = id > 0 ? id : 3;
            return View();
        }
    }
}
