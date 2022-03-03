using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace MISA.OrderManager
{
    [DependsOn(
        typeof(OrderManagerDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class OrderManagerApplicationContractsModule : AbpModule
    {

    }
}
