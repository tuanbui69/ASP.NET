using Bai3_Dinh_Tuan;
using Bai3_Dinh_Tuan.Models;

namespace Bai3_DinhTuan.Data
{
    public class SeedData
    {
        //Gia lap du lieu tu database
        public static List<Category> categories = new List<Category>()
        {
            new Category() { Id = 1, Name = "Category 1", Description = "Description 1" },
            new Category() { Id = 2, Name = "Category 2", Description = "Description 2" },
            new Category() { Id = 3, Name = "Category 3", Description = "Description 3" }
        };
    }
}
