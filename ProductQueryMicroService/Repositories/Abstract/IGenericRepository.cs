using ProductQueryMicroService.Entities.Abstracts;

namespace ProductQueryMicroService.Repositories.Abstract
{
    public interface IGenericRepository<T> where T : BaseEntity, new()
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
    }
}
