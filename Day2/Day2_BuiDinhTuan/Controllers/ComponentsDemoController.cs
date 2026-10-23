using Day2_BuiDinhTuan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2_BuiDinhTuan.Controllers
{
    /*
     * Controller minh họa so sánh Partial View và ViewComponent:
     * - Action Index() chuẩn bị danh sách Student để truyền cho Partial View.
     * - Lưu ý quan trọng: Controller hoàn toàn KHÔNG chuẩn bị dữ liệu cho QuickStatsViewComponent
     *   bởi vì ViewComponent sẽ tự query/tính toán độc lập khi view yêu cầu render.
     */
    public class ComponentsDemoController : Controller
    {
        public IActionResult Index()
        {
            // Dữ liệu Model này CHỈ phục vụ cho Partial View
            var students = new List<Student>
            {
                new Student { Id = 1, StudentCode = "SV001", FullName = "Bùi Đình Tuấn", Major = "Công nghệ thông tin", Gpa = 3.85 },
                new Student { Id = 2, StudentCode = "SV002", FullName = "Nguyễn Văn An", Major = "Khoa học máy tính", Gpa = 3.42 },
                new Student { Id = 3, StudentCode = "SV003", FullName = "Trần Thị Mai", Major = "Hệ thống thông tin", Gpa = 3.65 }
            };

            return View(students);
        }
    }
}
