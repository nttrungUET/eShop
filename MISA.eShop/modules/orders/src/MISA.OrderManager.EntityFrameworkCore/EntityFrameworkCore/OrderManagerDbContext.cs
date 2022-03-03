using Microsoft.EntityFrameworkCore;
using MISA.OrderManager.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MISA.OrderManager.EntityFrameworkCore
{
    [ConnectionStringName(OrderManagerDbProperties.ConnectionStringName)]
    public class OrderManagerDbContext : AbpDbContext<OrderManagerDbContext>, IOrderManagerDbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public OrderManagerDbContext(DbContextOptions<OrderManagerDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureOrderManager();
        }
    }
}