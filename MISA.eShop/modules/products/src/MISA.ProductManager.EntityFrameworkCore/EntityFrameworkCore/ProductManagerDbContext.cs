using Microsoft.EntityFrameworkCore;
using MISA.ProductManager.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MISA.ProductManager.EntityFrameworkCore
{
    [ConnectionStringName(ProductManagerDbProperties.ConnectionStringName)]
    public class ProductManagerDbContext : AbpDbContext<ProductManagerDbContext>, IProductManagerDbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductManagerDbContext(DbContextOptions<ProductManagerDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureProductManager();
        }
    }
}