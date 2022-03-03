namespace MISA.ProductManager
{
    public static class ProductManagerDbProperties
    {
        public static string DbTablePrefix { get; set; } = "ProductManager";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "ProductManager";
    }
}
