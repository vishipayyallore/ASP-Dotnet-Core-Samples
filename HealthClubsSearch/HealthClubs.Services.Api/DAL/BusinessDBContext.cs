using Microsoft.EntityFrameworkCore;
using HealthClubs.Data.Core.Models;

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
