using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MISA.ProductManager.EntityFrameworkCore
{
    [ConnectionStringName(ProductManagerDbProperties.ConnectionStringName)]
    public interface IProductManagerDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}