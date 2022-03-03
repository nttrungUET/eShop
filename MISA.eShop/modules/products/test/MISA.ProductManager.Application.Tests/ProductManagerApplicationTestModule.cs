using Volo.Abp.Modularity;

namespace MISA.ProductManager
{
    [DependsOn(
        typeof(ProductManagerApplicationModule),
        typeof(ProductManagerDomainTestModule)
        )]
    public class ProductManagerApplicationTestModule : AbpModule
    {

    }
}
