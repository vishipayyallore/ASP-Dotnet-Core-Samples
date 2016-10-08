using Microsoft.EntityFrameworkCore;
using Sales.Data.Core.Models;

namespace Sales.ServiceApi.Data
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
            : base(options)
        { }

        public DbSet<Product> ProductsListViewModels { get; set; }
    }
}
