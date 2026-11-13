using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace day5.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(100, ErrorMessage = "Tên sản phẩm tối đa 100 ký tự")]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Giá bán không được để trống")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá sản phẩm phải lớn hơn 0")]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Giá bán")]
        public decimal Price { get; set; }

        [Display(Name = "Số lượng tồn")]
        [Range(0, int.MaxValue, ErrorMessage = "Số lượng không được âm")]
        public int Stock { get; set; }

        [Display(Name = "Mô tả")]
        public string? Description { get; set; }
    }
}