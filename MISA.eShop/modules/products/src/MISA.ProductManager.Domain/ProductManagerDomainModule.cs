using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MISA.ProductManager
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(ProductManagerDomainSharedModule)
    )]
    public class ProductManagerDomainModule : AbpModule
    {

    }
}
