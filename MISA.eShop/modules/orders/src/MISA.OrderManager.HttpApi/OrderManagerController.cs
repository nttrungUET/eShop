using MISA.OrderManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MISA.OrderManager
{
    public abstract class OrderManagerController : AbpController
    {
        protected OrderManagerController()
        {
            LocalizationResource = typeof(OrderManagerResource);
        }
    }
}
