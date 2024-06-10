using ProductCommandMicroService.Entities.Abstracts;

namespace ProductCommandMicroService.Repositories.Abstracts
{
    public interface IGenericRepository<T>where T : BaseEntity
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();

    }
}
