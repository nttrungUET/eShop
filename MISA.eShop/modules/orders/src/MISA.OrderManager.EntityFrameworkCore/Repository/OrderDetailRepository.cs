using MISA.OrderManager.Entities;
using MISA.OrderManager.EntityFrameworkCore;
using MISA.OrderManager.OrderManagers;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MISA.OrderManager.Repository
{
    public class OrderDetailRepository : EfCoreRepository<OrderManagerDbContext, OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbContextProvider<OrderManagerDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
