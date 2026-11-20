using Microsoft.EntityFrameworkCore;

public class Day6_DinhTuanContext(DbContextOptions<Day6_DinhTuanContext> options) : DbContext(options)
{
    public DbSet<Day6_DinhTuan.Models.Product> Product { get; set; } = default!;
}
