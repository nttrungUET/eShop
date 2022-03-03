using System;

namespace MISA.OrderManager.Orders.Entities
{
    /// <summary>
    /// Lớp Dto chi tiết hóa đơn
    /// </summary>
    public class OrderDetailDto
    {
        /// <summary>
        /// Id chi tiết đơn hàng
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Mã sản phẩm
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Số lượng
        /// </summary>
        public int Quantity { get; set; }
    }
}
