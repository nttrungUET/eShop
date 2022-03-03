using MISA.ProductManager.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MISA.ProductManager
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(ProductManagerEntityFrameworkCoreTestModule)
        )]
    public class ProductManagerDomainTestModule : AbpModule
    {
        
    }
}
