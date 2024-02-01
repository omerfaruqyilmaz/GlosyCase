using CaseAPI.Infrastructure.Hubs.Product.Abstact;
using CaseAPI.Infrastructure.Hubs.Product.Concrete;

namespace CaseAPI.Infrastructure.Hubs
{
    public static class ServiceRegistration
    {
        public static void AddSignalRServices(this IServiceCollection collection)
        {
            collection.AddTransient<IProductHubService, ProductHubService>();
            collection.AddSignalR();
        }
    }
}
