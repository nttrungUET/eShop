using MISA.ProductManager.Localization;
using Volo.Abp.Application.Services;

namespace MISA.ProductManager
{
    public abstract class ProductManagerAppService : ApplicationService
    {
        protected ProductManagerAppService()
        {
            LocalizationResource = typeof(ProductManagerResource);
            ObjectMapperContext = typeof(ProductManagerApplicationModule);
        }
    }
}
