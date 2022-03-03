using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MISA.OrderManager.EntityFrameworkCore
{
    [ConnectionStringName(OrderManagerDbProperties.ConnectionStringName)]
    public interface IOrderManagerDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}