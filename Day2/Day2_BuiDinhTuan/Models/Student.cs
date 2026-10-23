namespace Day2_BuiDinhTuan.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentCode { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Major { get; set; } = string.Empty;
        public double Gpa { get; set; }
        public string AvatarUrl { get; set; } = string.Empty;
    }
}
