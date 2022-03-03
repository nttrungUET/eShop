namespace MISA.OrderManager
{
    public static class OrderManagerDbProperties
    {
        public static string DbTablePrefix { get; set; } = "OrderManager";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "OrderManager";
    }
}
