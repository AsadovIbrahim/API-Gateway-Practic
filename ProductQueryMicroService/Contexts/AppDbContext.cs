using Microsoft.EntityFrameworkCore;
using ProductQueryMicroService.Entities.Concretes;

namespace ProductQueryMicroService.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product>Products { get; set; } 
    }
}
