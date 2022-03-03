using System.Collections.Generic;

namespace MISA.OrderManager.Orders.Entities
{
    /// <summary>
    /// Lớp Dto tạo mới hóa đơn
    /// </summary>
    public class CreateOrderDto
    {
        /// <summary>
        /// Tên KH mua
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Danh sách mặt hàng mua trong hóa đơn
        /// </summary>
        public List<CreateOrderDetailDto> CreateOrderDetailDto { get; set; }
    }
}
