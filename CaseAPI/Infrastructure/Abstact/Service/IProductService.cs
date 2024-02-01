using CaseAPI.Core.Result;
using CaseAPI.Entities.Dto.Product.Request;

namespace CaseAPI.Infrastructure.Abstact.Service
{
    public interface IProductService
    {
        /// <summary>
        /// Ürünleri listeler
        /// </summary>
        /// <returns></returns>
        Task<DataResult> GetProductListAsync();

        /// <summary>
        /// Ürünleri listeler
        /// </summary>
        /// <returns></returns>
        Task<DataResult> AddProductAsync(AddProductRequest request);


        /// <summary>
        /// Ürünleri listeler
        /// </summary>
        /// <returns></returns>
        Task<DataResult> UpdateProductAsync(UpdateProductRequest request);


        /// <summary>
        /// Ürün listeler
        /// </summary>
        /// <returns></returns>
        Task<DataResult> DeleteProductAsync(int id);
    }
}
