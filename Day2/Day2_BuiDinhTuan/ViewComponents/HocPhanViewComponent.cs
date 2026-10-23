using Day2_BuiDinhTuan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2_BuiDinhTuan.ViewComponents
{
    public class HocPhanViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string title = "Danh sach hoc phan")
        {
            await Task.Yield();

            var hocPhans = new List<HocPhanItem>
            {
                new HocPhanItem { Id = 1, TenHocPhan = "ASP.NET Core MVC Cơ Bản", BoMon = "Bộ môn Công nghệ phần mềm", TrangThai = "Đã hoàn thành" },
                new HocPhanItem { Id = 2, TenHocPhan = "Views, Partial Views & ViewComponents", BoMon = "Bộ môn Công nghệ phần mềm", TrangThai = "Đang thực hành" },
                new HocPhanItem { Id = 3, TenHocPhan = "Entity Framework Core & SQL Server", BoMon = "Bộ môn Công nghệ phần mềm", TrangThai = "Sắp học" }
            };

            ViewBag.ComponentTitle = title;
            return View(hocPhans);
        }
    }
}
