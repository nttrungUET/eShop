using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace MISA.ProductManager
{
    [DependsOn(
        typeof(ProductManagerHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ProductManagerConsoleApiClientModule : AbpModule
    {
        
    }
}
