using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace MISA.OrderManager.Entities
{
    [Table("OrderDetail")]
    public partial class OrderDetail : IEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Mã order
        /// </summary>
        public Guid OrderId { get; set; }

        /// <summary>
        /// Mã sản phẩm
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Số lượng
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Thông tin đơn hàng
        /// </summary>
        public virtual Order Order { get; set; }

        public OrderDetail()
        {
            Id = Guid.NewGuid();
        }

        public OrderDetail(Guid orderDetailId)
        {
            Id = orderDetailId;
        }

        public object[] GetKeys()
        {
            return new object[] { Id };
        }
    }
}
