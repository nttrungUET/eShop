using MISA.OrderManager.Entities;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace MISA.OrderManager.OrderManagers
{
    public interface IOrderRepository : IBasicRepository<Order>
    {
        Task<Order> GetOrderById(Guid id);
    }
}
