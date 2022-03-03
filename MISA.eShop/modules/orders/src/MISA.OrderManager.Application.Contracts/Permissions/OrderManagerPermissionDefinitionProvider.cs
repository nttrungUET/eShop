using MISA.OrderManager.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MISA.OrderManager.Permissions
{
    public class OrderManagerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(OrderManagerPermissions.GroupName, L("Permission:OrderManager"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OrderManagerResource>(name);
        }
    }
}