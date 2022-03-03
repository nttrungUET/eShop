
namespace MISA.OrderManager.Enum
{
    /// <summary>
    /// Enum trạng thái đơn hàng
    /// </summary>
    public enum StateOrderEnum
    {
        /// <summary>
        /// Khởi tạo đơn hàng
        /// </summary>
        CreatedOrder = 0,

        /// <summary>
        /// Kiểm tra đơn hàng
        /// </summary>
        CheckedOrder = 1,

        /// <summary>
        /// Đã xuất kho
        /// </summary>
        ShippedOutInventory = 2,

        /// <summary>
        /// Chờ giao hàng
        /// </summary>
        WaitingForShip = 3,

        /// <summary>
        /// Đã giao hàng
        /// </summary>
        Shipped = 4,

        /// <summary>
        /// Kết thúc đơn hàng
        /// </summary>
        End = 5,

        /// <summary>
        /// Hủy đơn hàng
        /// </summary>
        Cancel = 6
    }
}
