using Microsoft.EntityFrameworkCore;
using MISA.OrderManager.Entities;
using MISA.OrderManager.EntityFrameworkCore;
using MISA.OrderManager.OrderManagers;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MISA.OrderManager.Repository
{
    public class OrderRepository : EfCoreRepository<OrderManagerDbContext, Order>, IOrderRepository, ISingletonDependency
    {
        public OrderRepository(IDbContextProvider<OrderManagerDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Order> GetOrderById(Guid id)
        {
            var db = await GetDbContextAsync();

            var order = db.Orders
                            .Include(a => a.OrderDetails.Select(c => c.OrderId == a.Id))
                            .AsNoTracking().Where(e => e.Id == id).ToList().FirstOrDefault();

            return order;
        }
    }
}
