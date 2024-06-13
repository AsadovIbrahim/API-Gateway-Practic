using Microsoft.AspNetCore.Mvc;
using ProductQueryMicroService.Repositories.Abstract;

namespace ProductQueryMicroService.Controllers
{
    public class ProductQueryController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductQueryController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet("GetAllProduct")]
        public async Task<IActionResult> GetAllProducts()
        {
            var data = await _productRepository.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("GetProductById")]
        public async Task<IActionResult>GetById(int id)
        {
           var data= await _productRepository.GetByIdAsync(id);
            return Ok(data);
        }
    }
}
