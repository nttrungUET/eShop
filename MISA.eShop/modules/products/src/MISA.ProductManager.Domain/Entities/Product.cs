using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace MISA.ProductManager.Entities
{
    /// <summary>
    /// Bảng Product
    /// </summary>
    [Table("product")]
    public class Product : IEntity<Guid>
    {
        /// <summary>
        /// ID Product
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Mã sản phẩm
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// Tên sản phẩm
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Giá
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Số lượng hiện có trong kho
        /// </summary>
        public int Stock { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }

        public Product(Guid id)
        {
            Id = id;
        }
        public object[] GetKeys()
        {
            return new object[] { Id };
        }
    }
}
