using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MISA.OrderManager
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(OrderManagerDomainSharedModule)
    )]
    public class OrderManagerDomainModule : AbpModule
    {

    }
}
