using Volo.Abp.Reflection;

namespace MISA.ProductManager.Permissions
{
    public class ProductManagerPermissions
    {
        public const string GroupName = "ProductManager";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProductManagerPermissions));
        }
    }
}