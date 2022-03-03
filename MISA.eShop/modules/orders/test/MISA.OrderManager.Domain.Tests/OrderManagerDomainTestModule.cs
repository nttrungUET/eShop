using MISA.OrderManager.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MISA.OrderManager
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(OrderManagerEntityFrameworkCoreTestModule)
        )]
    public class OrderManagerDomainTestModule : AbpModule
    {
        
    }
}
