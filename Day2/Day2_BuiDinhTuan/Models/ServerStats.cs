namespace Day2_BuiDinhTuan.Models
{
    public class ServerStats
    {
        public DateTime GeneratedTime { get; set; } = DateTime.Now;
        public int ActiveUsers { get; set; }
        public int TotalArticles { get; set; }
        public double MemoryUsageMB { get; set; }
        public string ComponentTitle { get; set; } = string.Empty;
    }
}
