using Day2_BuiDinhTuan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2_BuiDinhTuan.ViewComponents
{
    /*
     * ============================================================================
     * VIEWCOMPONENT DEMO: QuickStatsViewComponent
     * Đặc điểm:
     * - Kế thừa từ class ViewComponent của Microsoft.AspNetCore.Mvc.
     * - Có C# logic riêng, hỗ trợ Dependency Injection (DI) đầy đủ.
     * - Tự chủ (self-contained): Tự query dữ liệu hoặc tính toán mà Controller cha 
     *   không cần biết, không cần truyền qua Model/ViewData.
     * ============================================================================
     */
    public class QuickStatsViewComponent : ViewComponent
    {
        private readonly ILogger<QuickStatsViewComponent>? _logger;

        // Minh họa hỗ trợ Dependency Injection (DI) trong ViewComponent
        public QuickStatsViewComponent(ILogger<QuickStatsViewComponent>? logger = null)
        {
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync(string title = "Thống Kê Hệ Thống")
        {
            // Giả lập logic tính toán hoặc query dữ liệu độc lập
            await Task.Delay(10); // Giả lập async call

            var stats = new ServerStats
            {
                ComponentTitle = title,
                GeneratedTime = DateTime.Now,
                ActiveUsers = new Random().Next(15, 60),
                TotalArticles = 128,
                MemoryUsageMB = Math.Round(GC.GetTotalMemory(false) / (1024.0 * 1024.0), 2)
            };

            // Trả dữ liệu sang file Views/Shared/Components/QuickStats/Default.cshtml
            return View(stats);
        }
    }
}
