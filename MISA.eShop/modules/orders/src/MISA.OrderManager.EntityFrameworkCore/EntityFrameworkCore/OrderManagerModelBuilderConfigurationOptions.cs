using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MISA.OrderManager.EntityFrameworkCore
{
    public class OrderManagerModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public OrderManagerModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}