using CaseAPI.Infrastructure.Hubs.Product;

namespace CaseAPI.Infrastructure.Hubs
{
    public static class HubRegistration
    {
        public static void MapHubs(this WebApplication webApplication)
        {
            webApplication.MapHub<ProductHub>("/product-hub");
        }
    }
}
