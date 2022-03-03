using MISA.OrderManager.Entities;
using System;
using Volo.Abp.Domain.Repositories;

namespace MISA.OrderManager.OrderManagers
{
    public interface IOrderDetailRepository : IBasicRepository<OrderDetail>
    {
    }
}
