using Localization.Resources.AbpUi;
using MISA.OrderManager.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using MISA.OrderManager.EntityFrameworkCore;
using Volo.Abp;

namespace MISA.OrderManager
{
    [DependsOn(
        typeof(OrderManagerApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class OrderManagerHttpApiModule : AbpModule
    {

        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(OrderManagerHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<OrderManagerResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
