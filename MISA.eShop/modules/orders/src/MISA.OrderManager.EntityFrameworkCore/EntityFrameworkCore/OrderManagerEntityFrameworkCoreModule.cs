using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MISA.OrderManager.EntityFrameworkCore
{
    [DependsOn(
        typeof(OrderManagerDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class OrderManagerEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<OrderManagerDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
            });

            Configure<AbpDbContextOptions>(options =>
            {
                // Cấu hình repository sử dụng database Mariadb
                options.UseMySQL();
            });
        }
    }
}