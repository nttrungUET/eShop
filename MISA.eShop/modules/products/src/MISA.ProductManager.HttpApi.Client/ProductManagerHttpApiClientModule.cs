using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace MISA.ProductManager
{
    [DependsOn(
        typeof(ProductManagerApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ProductManagerHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "ProductManager";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ProductManagerApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
