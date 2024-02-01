using CaseAPI.Core.Result;
using CaseAPI.Entities.Dto.Product.Request;
using CaseAPI.Infrastructure.Abstact.Service;
using Microsoft.AspNetCore.Mvc;

namespace CaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("products")]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            DataResult dataResult = await _productService.GetProductListAsync();
            return dataResult.HttpResponse();
        }

        [HttpPost]
        [Route("add-product")]
        public async Task<IActionResult> AddProductAsync(AddProductRequest request)
        {
            DataResult dataResult = await _productService.AddProductAsync(request);
            return dataResult.HttpResponse();
        }

        [HttpPut]
        [Route("update-product")]
        public async Task<IActionResult> UpdateProductAsync(UpdateProductRequest request)
        {
            DataResult dataResult = await _productService.UpdateProductAsync(request);
            return dataResult.HttpResponse();
        }

        [HttpDelete]
        [Route("delete-product")]
        public async Task<IActionResult> DeleteProductAsync(int id)
        {
            DataResult dataResult = await _productService.DeleteProductAsync(id);
            return dataResult.HttpResponse();
        }
    }
}
