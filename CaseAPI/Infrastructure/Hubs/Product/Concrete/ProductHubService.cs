using AutoMapper;
using CaseAPI.Entities.Dto.Product.Response;
using CaseAPI.Entities.Entity;
using CaseAPI.Infrastructure.Abstact.Query;
using CaseAPI.Infrastructure.Constants;
using CaseAPI.Infrastructure.Hubs.Product;
using CaseAPI.Infrastructure.Hubs.Product.Abstact;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CaseAPI.Infrastructure.Hubs.Product.Concrete
{
    public class ProductHubService : IProductHubService
    {
        private readonly IHubContext<ProductHub> _hubContext;
        private readonly IProductQuery _productQuery;
        private readonly IMapper _mapper;
        public ProductHubService(IHubContext<ProductHub> hubContext, IProductQuery productQuery,IMapper mapper)
        {
            _hubContext = hubContext;
            _productQuery = productQuery;
            _mapper = mapper;
        }

        public async Task SendProductList()
        {
            List<CaseAPI.Entities.Entity.Product> products = await _productQuery.GetAll(c=>c.IsStatus && c.IsDeleted == false);

            List<ProductListResponse> response = products.Select(item =>_mapper.Map<ProductListResponse>(item)).ToList();

            await _hubContext.Clients.All.SendAsync(ReceiveFunctionNames.ReceiveProductList, response);
        }     
    }
}
