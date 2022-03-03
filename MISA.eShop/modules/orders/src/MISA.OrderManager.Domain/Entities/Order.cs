using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace MISA.OrderManager.Entities
{
    /// <summary>
    /// Bảng Order
    /// </summary>
   [Table("Order")]
    public partial class Order : IEntity
    {
        /// <summary>
        /// Mã đơn hàng
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Ngày đặt hàng
        /// </summary>
        public DateTime OrderDate { get; set; }

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
        /// Tên KH mua
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Thông tin chi tiết đơn hàng
        /// </summary>
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            Id = Guid.NewGuid();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public Order(Guid orderId)
        {
            Id = orderId;
        }

        public object[] GetKeys()
        {
            return new object[] { Id };
        }
    }
}
