using Volo.Abp.Modularity;

namespace MISA.OrderManager
{
    [DependsOn(
        typeof(OrderManagerApplicationModule),
        typeof(OrderManagerDomainTestModule)
        )]
    public class OrderManagerApplicationTestModule : AbpModule
    {

    }
}
