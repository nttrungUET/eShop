using System;

namespace MISA.OrderManager.Orders.Entities
{
    public class CreateOrderDetailDto
    {
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
