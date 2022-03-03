using Volo.Abp.Reflection;

namespace MISA.OrderManager.Permissions
{
    public class OrderManagerPermissions
    {
        public const string GroupName = "OrderManager";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(OrderManagerPermissions));
        }
    }
}