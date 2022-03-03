using MISA.ProductManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MISA.ProductManager
{
    public abstract class ProductManagerController : AbpController
    {
        protected ProductManagerController()
        {
            LocalizationResource = typeof(ProductManagerResource);
        }
    }
}
