using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MISA.ProductManager.EntityFrameworkCore
{
    public class ProductManagerModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ProductManagerModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}