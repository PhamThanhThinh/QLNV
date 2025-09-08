using Microsoft.EntityFrameworkCore;
using QLNV.Data.Entities;

namespace QLNV.Data
{
  public class QLNVDbContext : DbContext
  {
    public QLNVDbContext(DbContextOptions options) : base(options)
    {
    }

    //protected QLNVDbContext()
    //{
    //}

    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      // tạo method dùng để khởi tạo dữ liệu cho database
      modelBuilder.DataSeeder();
    }

  }
}
