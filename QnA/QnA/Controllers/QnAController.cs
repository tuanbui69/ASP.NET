using Microsoft.AspNetCore.Mvc;

namespace QnA.Controllers
{
    public class QnAController : Controller
    {
        // Action Index trả về view Index
        public IActionResult Index()
        {
            return View();
        }

        // Action Ask trả về view Ask, truyền câu hỏi qua ViewBag
        public IActionResult Ask()
        {
            ViewBag.Question = "Học lập trình ASP.NET Core có khó không?";
            return View();
        }

        // Action Answer trả về view Answer, truyền câu trả lời qua ViewData
        public IActionResult Answer()
        {
            ViewData["Answer"] = "Không khó nếu nắm vững mô hình MVC và luyện tập thường xuyên!";
            return View();
        }
    }
}













//Câu 1: Action / Controller:
//Tạo project QnA.
//Tạo QnAController.
//Action Index trả về view Index.
//Action Ask trả về view Ask, truyền câu hỏi qua ViewBag.
//Action Answer trả về view Answer, truyền câu trả lời qua ViewData.

//Câu 2: View:
//View Index hiển thị “Trang hỏi đáp”.
//View Ask hiển thị câu hỏi từ ViewBag.
//View Answer hiển thị câu trả lời từ ViewData.
//Tạo partial view _QnAFooter, nội dung: “Hãy đặt câu hỏi cho chúng tôi!”.
//Nhúng _QnAFooter vào các view.