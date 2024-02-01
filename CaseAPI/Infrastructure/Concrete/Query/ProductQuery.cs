using CaseAPI.Core.DataAccess.EntityFramework;
using CaseAPI.DataAccess.Concrete;
using CaseAPI.Entities.Entity;
using CaseAPI.Infrastructure.Abstact.Query;

namespace CaseAPI.Infrastructure.Concrete.Query
{
    public class ProductQuery : EfEntityRepositoryBase<Product, ProjectDbContext>, IProductQuery
    {

    }

}
