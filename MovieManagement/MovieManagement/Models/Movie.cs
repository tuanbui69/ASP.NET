using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieManagement.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên phim")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng chọn ngày phát hành")]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập thời lượng")]
        [Range(1, 1000, ErrorMessage = "Thời lượng phải lớn hơn 0")]
        public int Duration { get; set; }

        // Khóa ngoại liên kết với bảng Genre
        [Required(ErrorMessage = "Vui lòng chọn thể loại")]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [ForeignKey("GenreId")]
        public Genre? Genre { get; set; }
    }
}