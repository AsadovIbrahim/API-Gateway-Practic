using Microsoft.EntityFrameworkCore;
using ProductCommandMicroService.Entities.Concretes;

namespace ProductCommandMicroService.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
