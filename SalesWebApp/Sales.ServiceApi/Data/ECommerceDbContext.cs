using Microsoft.EntityFrameworkCore;
using Sales.ServiceApi.Data.ViewModels;

namespace Sales.ServiceApi.Data
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
            : base(options)
        { }

        public DbSet<ProductsViewModel> ProductsListViewModels { get; set; }
    }
}
