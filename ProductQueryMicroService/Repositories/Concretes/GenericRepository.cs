using Microsoft.EntityFrameworkCore;
using ProductQueryMicroService.Contexts;
using ProductQueryMicroService.Entities.Abstracts;
using ProductQueryMicroService.Repositories.Abstract;

namespace ProductQueryMicroService.Repositories.Concretes
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
    {
        protected readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
