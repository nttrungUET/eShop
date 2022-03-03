using MISA.OrderManager.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MISA.OrderManager.Orders
{
    public interface IOrderAppService : IApplicationService
    {
        /// <summary>
        /// Tạo mới đơn hàng
        /// </summary>
        /// <param name="createOrderDto">Tham số tạo mới đơn hàng</param>
        /// <returns></returns>
        Task<OrderDto> CreateAsync(CreateOrderDto createOrderDto);

        /// <summary>
        /// Lấy thông tin đơn hàng theo ID
        /// </summary>
        /// <param name="orderId">Id hóa đơn</param>
        /// <returns></returns>
        Task<OrderDto> GetOrderByIdAsync(Guid orderId);

        /// <summary>
        /// Lấy tất cả danh sách hóa đơn
        /// </summary>
        /// <returns></returns>
        Task<List<OrderDto>> GetAllOrderAsync();

        /// <summary>
        /// Cập nhật thông tin đơn hàng
        /// </summary>
        /// <param name="updateOrderDto"></param>
        /// <returns></returns>
        Task<OrderDto> UpdateAsync(Guid orderId, UpdateOrderDto updateOrderDto);

        /// <summary>
        /// Xóa đơn hàng
        /// </summary>
        /// <param name="orderId">Id đơn hàng</param>
        /// <returns></returns>
        Task<bool> DeleteAsync(Guid orderId);
    }
}
