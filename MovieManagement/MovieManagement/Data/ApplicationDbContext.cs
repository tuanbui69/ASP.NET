using Microsoft.EntityFrameworkCore;
using MovieManagement.Models;

namespace MovieManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Hành động" },
                new Genre { Id = 2, Name = "Phiêu lưu" },
                new Genre { Id = 3, Name = "Hài kịch" },
                new Genre { Id = 4, Name = "Chính kịch" },
                new Genre { Id = 5, Name = "Kinh dị" },
                new Genre { Id = 6, Name = "Khoa học viễn tưởng" },
                new Genre { Id = 7, Name = "Giả tưởng" },
                new Genre { Id = 8, Name = "Lãng mạn" },
                new Genre { Id = 9, Name = "Giật gân" },
                new Genre { Id = 10, Name = "Hoạt hình" }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Phim 1", ReleaseDate = new DateTime(2025, 1, 15), Duration = 100, GenreId = 1 },
                new Movie { Id = 2, Title = "Phim 2", ReleaseDate = new DateTime(2026, 5, 20), Duration = 120, GenreId = 3 }
            );
        }
    }
}