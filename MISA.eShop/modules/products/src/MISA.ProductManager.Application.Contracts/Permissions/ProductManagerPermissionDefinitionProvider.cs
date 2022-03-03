using MISA.ProductManager.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MISA.ProductManager.Permissions
{
    public class ProductManagerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ProductManagerPermissions.GroupName, L("Permission:ProductManager"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ProductManagerResource>(name);
        }
    }
}