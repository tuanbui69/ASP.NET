using Microsoft.AspNetCore.Mvc;

namespace Day2_BuiDinhTuan.Controllers
{
    /*
     * ============================================================================
     * ATTRIBUTE ROUTING DEMO: AttributeRoutingDemoController
     * Đặc điểm:
     * - Route được khai báo trực tiếp bằng Attributes ([Route], [HttpGet],...)
     * - Không phụ thuộc vào cấu hình tập trung trong Program.cs.
     * - Hỗ trợ Route Constraints (:int, :alpha,...), Token Replacement [controller], [action]
     * - Cho phép tạo URL thân thiện chuẩn SEO (SEO-friendly URL).
     * ============================================================================
     */
    [Route("dinh-tuyen-thuoc-tinh")] // Tiền tố URL cấp Controller
    public class AttributeRoutingDemoController : Controller
    {
        public class Course
        {
            public int Id { get; set; }
            public string Title { get; set; } = string.Empty;
            public string Slug { get; set; } = string.Empty;
            public int Credits { get; set; }
            public string Description { get; set; } = string.Empty;
        }

        private static readonly List<Course> SampleCourses = new()
        {
            new Course { Id = 101, Title = "Lập trình Web với ASP.NET Core", Slug = "lap-trinh-asp-net-core", Credits = 3, Description = "Khóa học chuyên sâu về MVC, ViewComponent, Entity Framework Core và RESTful API." },
            new Course { Id = 102, Title = "Cấu trúc dữ liệu và giải thuật C#", Slug = "cau-truc-du-lieu-csharp", Credits = 4, Description = "Nắm vững các thuật toán tìm kiếm, sắp xếp và tối ưu hóa hiệu năng." },
            new Course { Id = 103, Title = "Kiến trúc hệ thống phần mềm Microservices", Slug = "kien-truc-microservices", Credits = 3, Description = "Thiết kế hệ thống chịu tải cao với Docker, Kubernetes và gRPC." }
        };

        // Khớp URL: /dinh-tuyen-thuoc-tinh hoặc /dinh-tuyen-thuoc-tinh/danh-sach
        [HttpGet("")]
        [HttpGet("danh-sach")]
        public IActionResult Index()
        {
            return View(SampleCourses);
        }

        // Khớp URL: /dinh-tuyen-thuoc-tinh/khoa-hoc/{id:int}/{slug?}
        // Minh họa Route Constraint :int (id bắt buộc là số nguyên) và tham số tùy chọn {slug?}
        [HttpGet("khoa-hoc/{id:int}/{slug?}")]
        public IActionResult Details(int id, string? slug)
        {
            var course = SampleCourses.FirstOrDefault(c => c.Id == id);
            if (course == null)
            {
                return NotFound($"Không tìm thấy khóa học có mã {id}");
            }

            ViewData["PassedSlug"] = slug ?? "khong-co-slug";
            return View(course);
        }
    }
}
