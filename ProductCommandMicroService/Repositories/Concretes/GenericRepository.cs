using Microsoft.EntityFrameworkCore;
using ProductCommandMicroService.Contexts;
using ProductCommandMicroService.Entities.Abstracts;
using ProductCommandMicroService.Repositories.Abstracts;

namespace ProductCommandMicroService.Repositories.Concretes
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
    {
        protected readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _context.Set<T>().FirstOrDefaultAsync(p => p.Id == id);
            _context.Set<T>().Remove(data!);
            await _context.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
