using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên thể loại")]
        [Display(Name = "Thể loại")]
        public string Name { get; set; } = string.Empty;

        public ICollection<Movie>? Movies { get; set; }
    }
}