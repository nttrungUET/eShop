using MISA.OrderManager.Localization;
using Volo.Abp.Application.Services;

namespace MISA.OrderManager
{
    public abstract class OrderManagerAppService : ApplicationService
    {
        protected OrderManagerAppService()
        {
            LocalizationResource = typeof(OrderManagerResource);
            ObjectMapperContext = typeof(OrderManagerApplicationModule);
        }
    }
}
