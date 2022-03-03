using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace MISA.OrderManager
{
    [DependsOn(
        typeof(OrderManagerHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class OrderManagerConsoleApiClientModule : AbpModule
    {
        
    }
}
