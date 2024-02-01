using CaseAPI.Entities.Entity;
using Microsoft.EntityFrameworkCore;

namespace CaseAPI.DataAccess.Concrete
{
    public class ProjectDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot myConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(myConfig.GetSection("Database:ConnectionString").Value);
        }



        public DbSet<Product> Products { get; set; }
    }
}
