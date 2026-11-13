using Microsoft.AspNetCore.Mvc;

namespace StudentController
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Infor(string infor)
        {
            ViewBag.Student = infor;
            return View();
        }

        public IActionResult Score()
        {
            ViewData["Score"] = "36";
            return View();
        }
    }
}