using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace MISA.OrderManager
{
    [DependsOn(
        typeof(OrderManagerApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class OrderManagerHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "OrderManager";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(OrderManagerApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
