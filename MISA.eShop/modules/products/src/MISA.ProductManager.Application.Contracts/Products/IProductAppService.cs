using MISA.ProductManager.Products.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MISA.ProductManager.Products
{
    public interface IProductAppService : IApplicationService
    {
        /// <summary>
        /// Tạo mới sản phẩm
        /// </summary>
        /// <param name="createProductDto">Tham số tạo mới sản phẩm</param>
        /// <returns></returns>
        Task<ProductDto> CreateAsync(CreateProductDto createProductDto);

        /// <summary>
        /// Lấy thông tin sản phẩm theo ID
        /// </summary>
        /// <param name="productId">Id sản phẩm</param>
        /// <returns></returns>
        Task<ProductDto> GetProductByIdAsync(Guid productId);

        /// <summary>
        /// Lấy tất cả danh sách sản phẩm
        /// </summary>
        /// <returns></returns>
        Task<List<ProductDto>> GetAllProductAsync();

        /// <summary>
        /// Cập nhật thông tin sản phẩm
        /// </summary>
        /// <param name="productId">Id sản phẩm</param>
        /// <param name="updateProductDto">Thông tin cập nhật sản phẩm</param>
        /// <returns></returns>
        Task<ProductDto> UpdateAsync(Guid productId, UpdateProductDto updateProductDto);

        /// <summary>
        /// Xóa sản phẩm
        /// </summary>
        /// <param name="orderId">Id sản phẩm</param>
        /// <returns></returns>
        Task<bool> DeleteAsync(Guid orderId);
    }
}
