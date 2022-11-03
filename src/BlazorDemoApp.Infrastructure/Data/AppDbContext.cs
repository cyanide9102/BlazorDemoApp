using System.Reflection;

using BlazorDemoApp.Core.Entities.BrandAggregate;
using BlazorDemoApp.Core.Entities.CategoryAggregate;
using BlazorDemoApp.Core.Entities.ProductAggregate;

using Microsoft.EntityFrameworkCore;

namespace BlazorDemoApp.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
