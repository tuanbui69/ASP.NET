using Microsoft.AspNetCore.Mvc;

namespace Day2_BuiDinhTuan.Controllers
{
    [Route("san-pham")]
    public class SanPhamController : Controller
    {
        public class SanPhamModel
        {
            public int MaSP { get; set; }
            public string TenSanPham { get; set; } = string.Empty;
            public string GiangVien { get; set; } = string.Empty;
            public string TrangThai { get; set; } = string.Empty;
        }

        private static readonly List<SanPhamModel> DanhSachSanPham = new()
        {
            new SanPhamModel { MaSP = 101, TenSanPham = "Khóa học ASP.NET Core MVC Toàn Diện", GiangVien = "Bộ môn Công nghệ phần mềm", TrangThai = "Còn chỗ" },
            new SanPhamModel { MaSP = 102, TenSanPham = "Khóa học Entity Framework Core Nâng Cao", GiangVien = "Bộ môn Công nghệ phần mềm", TrangThai = "Mới mở" },
            new SanPhamModel { MaSP = 103, TenSanPham = "Khóa học Thiết kế Web API & Microservices", GiangVien = "Bộ môn Công nghệ phần mềm", TrangThai = "Hot" }
        };

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(DanhSachSanPham);
        }

        [HttpGet("chi-tiet/{id:int}")]
        public IActionResult Details(int id)
        {
            ViewData["MaSP"] = id;
            return View();
        }
    }
}
