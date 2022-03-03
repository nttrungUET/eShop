using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MISA.ProductManager.EntityFrameworkCore
{
    [DependsOn(
        typeof(ProductManagerDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class ProductManagerEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ProductManagerDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
            });

            Configure<AbpDbContextOptions>(options => {
                // Cấu hình sử dụng database MariaDb
                options.UseMySQL();
            });
        }
    }
}