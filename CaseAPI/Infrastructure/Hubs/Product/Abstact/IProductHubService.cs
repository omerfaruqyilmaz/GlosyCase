using CaseAPI.Entities.Dto.Product.Response;

namespace CaseAPI.Infrastructure.Hubs.Product.Abstact
{
    public interface IProductHubService
    {
        Task SendProductList();
    }
}
