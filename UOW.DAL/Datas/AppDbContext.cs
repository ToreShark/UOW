using Microsoft.EntityFrameworkCore;
using UOW.DAL.Entities;

namespace UOW.DAL.Datas;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Orders> Orders { get; set; } = null!;
}