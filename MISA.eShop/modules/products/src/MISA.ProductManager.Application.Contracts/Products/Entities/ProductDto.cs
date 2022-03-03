using System;

namespace MISA.ProductManager.Products.Entities
{
    public class ProductDto
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
    }
}
