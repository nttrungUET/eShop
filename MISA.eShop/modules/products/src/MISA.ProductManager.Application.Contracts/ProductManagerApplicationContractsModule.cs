using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace MISA.ProductManager
{
    [DependsOn(
        typeof(ProductManagerDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class ProductManagerApplicationContractsModule : AbpModule
    {

    }
}
