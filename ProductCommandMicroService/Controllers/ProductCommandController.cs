using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCommandMicroService.Entities.Concretes;
using ProductCommandMicroService.Repositories.Abstracts;

namespace ProductCommandMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCommandController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductCommandController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpPost("AddProduct")]
        public async Task<IActionResult>AddProductAsync(Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            await _productRepository.AddAsync(product);
            return Ok();
        }

        [HttpPost("DeleteProduct")]

        public async Task<IActionResult>DeleteProductAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
            return Ok();
        }

    }
}
