using HealthClubs.Data.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthClubs.Data.Store
{

    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext(DbContextOptions<BusinessDbContext> options)
            : base(options)
        { }

        public DbSet<Business> Businesses { get; set; }
    }

}
