using Microsoft.EntityFrameworkCore;

namespace HealthClubs.Services.Api.DAL
{

    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext(DbContextOptions<BusinessDbContext> options)
            : base(options)
        { }

        public DbSet<Business> Businesses { get; set; }
    }

}
