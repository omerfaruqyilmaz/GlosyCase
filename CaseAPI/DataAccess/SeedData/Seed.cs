using CaseAPI.DataAccess.Concrete;
using CaseAPI.Entities.Entity;
using Microsoft.EntityFrameworkCore;

namespace CaseAPI.DataAccess.DataSeeding
{
    public static class Seed
    {
        public static void Init(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<ProjectDbContext>();
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                context.Products.AddRange(new List<Product>()
                {
                    new Product() { CategoryName =  "Giyim", Title = "Siyah Erkek Tişört", CreatedAt = DateTime.Now, IsDeleted = false, IsStatus = true,Price = 120,},
                    new Product() { CategoryName =  "Giyim", Title = "Gri Boğazlı Kazak", CreatedAt = DateTime.Now, IsDeleted = false, IsStatus = true,Price = 195,},
                    new Product() { CategoryName =  "Giyim", Title = "Mavi Etek", CreatedAt = DateTime.Now, IsDeleted = false, IsStatus = true,Price = 149},
                    new Product() { CategoryName =  "Gıda", Title = "Yağ 5 KG", CreatedAt = DateTime.Now, IsDeleted = false, IsStatus = true,Price = 130},
                    new Product() { CategoryName =  "Gıda", Title = "Spagetti", CreatedAt = DateTime.Now, IsDeleted = false, IsStatus = true,Price = 13},
                    new Product() { CategoryName =  "İçecek", Title = "Ice Tea Mango", CreatedAt = DateTime.Now, IsDeleted = false, IsStatus = true,Price = 8}

                });
            }

            context.SaveChanges();
        }
    }
}
