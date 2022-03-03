using Localization.Resources.AbpUi;
using MISA.ProductManager.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

namespace MISA.ProductManager
{
    [DependsOn(
        typeof(ProductManagerApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class ProductManagerHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(ProductManagerHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ProductManagerResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }

    }
}
