using AutoMapper;
using CaseAPI.Core.DataAccess.EntityFramework;
using CaseAPI.Core.Result;
using CaseAPI.DataAccess.Concrete;
using CaseAPI.Entities.Dto.Product.Request;
using CaseAPI.Entities.Dto.Product.Response;
using CaseAPI.Entities.Entity;
using CaseAPI.Infrastructure.Abstact.Query;
using CaseAPI.Infrastructure.Abstact.Service;
using CaseAPI.Infrastructure.Constants;
using CaseAPI.Infrastructure.Hubs.Product.Abstact;

namespace CaseAPI.Infrastructure.Concrete.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductQuery _productQuery;
        private readonly IMapper _mapper;
        private readonly IProductHubService _productHubService;

        public ProductService(IProductQuery productQuery, IMapper mapper,IProductHubService productHubService)
        {
            _productQuery = productQuery;
            _mapper = mapper;
            _productHubService = productHubService;
        }

        public async Task<DataResult> AddProductAsync(AddProductRequest request)
        {
            DataResult dataResult = new();

            Product entity = _mapper.Map<Product>(request);

            entity.IsDeleted = false;
            entity.IsStatus = true;
            entity.CreatedAt = DateTime.Now;

            int execute = await _productQuery.Add(entity);

            if (execute > 0)
            {
                await _productHubService.SendProductList();
                dataResult.Data = GeneralMessages.ProductAdded;
                return dataResult;
            }

            dataResult.ErrorMessageList.Add(GeneralMessages.TransactionFailed);
            return dataResult;
        }

        public async Task<DataResult> DeleteProductAsync(int id)
        {
            DataResult dataResult = new();

            Product product = await _productQuery.Get(x => x.Id == id && x.IsStatus == true && x.IsDeleted == false);

            if (product is null)
            {
                dataResult.ErrorMessageList.Add(GeneralMessages.ProductNotFound);
                return dataResult;
            }

            product.IsDeleted = true;
            product.IsStatus = false;
            product.UpdatedAt = DateTime.Now;
            
            await _productQuery.Update(product);
            await _productHubService.SendProductList();


            dataResult.Data = GeneralMessages.ProductDeleted;
            return dataResult;
        }

        public async Task<DataResult> GetProductListAsync()
        {
            DataResult dataResult = new();

            List<Product> list = await _productQuery.GetAll(c => c.IsStatus);

            if (list.Any())
            {
                List<ProductListResponse> response = list.Select(item =>
                    _mapper.Map<ProductListResponse>(item)
                ).ToList();

                dataResult.Data = response;
                dataResult.Total = response.Count;
            }

            return dataResult;
        }

        public async Task<DataResult> UpdateProductAsync(UpdateProductRequest request)
        {
            DataResult dataResult = new();

            Product product = await _productQuery.Get(x => x.Id == request.Id && x.IsStatus == true && x.IsDeleted == false);

            if (product is null)
            {
                dataResult.ErrorMessageList.Add(GeneralMessages.ProductNotFound);
                return dataResult;
            }

            Product entity = _mapper.Map<Product>(request);
            
            entity.UpdatedAt = DateTime.Now;
            entity.IsStatus = true;
            entity.IsDeleted = false;

            int execute = await _productQuery.Update(entity);

            if (execute > 0)
            {
                await _productHubService.SendProductList();
                dataResult.Data = GeneralMessages.ProductUpdated;
                return dataResult;
            }

            dataResult.ErrorMessageList.Add(GeneralMessages.TransactionFailed);
            return dataResult;
        }
    }

}
