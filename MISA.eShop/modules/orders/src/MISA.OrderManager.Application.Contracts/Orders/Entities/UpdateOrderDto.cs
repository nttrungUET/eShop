using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace MISA.OrderManager.Orders.Entities
{
    public class UpdateOrderDto
    {
        /// <summary>
        /// Mã hóa đơn
        /// </summary>
        public Guid OrderId { get; set; }

        /// <summary>
        /// Ngày đặt hàng
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Tên KH mua
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Trạng thái của hóa đơn.
        /// 0. Khởi tạo đơn hàng.
        /// 1. Kiểm tra đơn hàng.
        /// 2. Đã xuất kho.
        /// 3. Chờ giao hàng.
        /// 4. Đã giao hàng.
        /// 5. Kết thúc đơn hàng.
        /// 6. Hủy đơn hàng.
        /// </summary>
        public int StateOrder { get; set; }

        /// <summary>
        /// Trạng thái đang gặp lỗi (mặc định -1 là không lỗi)
        /// </summary>
        public int StateError { get; set; } = -1;

        /// <summary>
        /// Danh sách mặt hàng mua trong hóa đơn
        /// </summary>
        public List<OrderDetailDto> OrderDetailDto { get; set; }
    }
}
