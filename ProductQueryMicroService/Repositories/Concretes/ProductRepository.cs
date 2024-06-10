using ProductQueryMicroService.Contexts;
using ProductQueryMicroService.Entities.Concretes;
using ProductQueryMicroService.Repositories.Abstract;

namespace ProductQueryMicroService.Repositories.Concretes
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
