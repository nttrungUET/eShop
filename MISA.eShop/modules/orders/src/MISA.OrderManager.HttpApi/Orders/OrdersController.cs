using Microsoft.AspNetCore.Mvc;
using MISA.OrderManager.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;

namespace MISA.OrderManager.Orders
{
    [RemoteService]
    [Route("api/v1/orders")]
    public class OrdersController : OrderManagerController
    {
        private readonly IOrderAppService _orderAppService;

        public OrdersController(IOrderAppService orderAppService)
        {
            _orderAppService = orderAppService;
        }

        // GET: api/<ValuesController>
        /// <summary>
        /// API Lấy tất cả danh sách hóa đơn hiện có
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<OrderDto>> GetAll()
        {
            return await _orderAppService.GetAllOrderAsync();
        }

        // GET api/<ValuesController>/5
        /// <summary>
        /// API lấy hóa đơn theo ID
        /// </summary>
        /// <param name="orderId">Id hóa đơn</param>
        /// <returns></returns>
        [HttpGet("{orderId}")]
        public async Task<OrderDto> Get(Guid orderId)
        {
            return await _orderAppService.GetOrderByIdAsync(orderId);
        }

        // POST api/<ValuesController>
        /// <summary>
        /// Tạo mới hóa đơn mua hàng
        /// </summary>
        /// <param name="createOrderDto">Tham số tạo mới đơn hàng</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<OrderDto> Post([FromBody] CreateOrderDto createOrderDto)
        {
            // khởi tạo đơn hàng tại service order (đặt trạng thái - khởi tạo đơn hàng)
            var orderDto = await _orderAppService.CreateAsync(createOrderDto);

            // khởi tạo thành công => gọi sang service product để xử lý
            if (orderDto != null)
            {
                // 1. Kiểm tra số lượng sản phẩm có đủ so với số lượng mua
                // 1.1. Nếu đủ - cập nhật lại số lượng product => order cập nhật trạng thái mua hàng tiếp theo (thanh toán)
                // 1.2. Nếu không đủ => order cập nhật trạng thái mua hàng thất bại
            }

            return orderDto;
        }

        // PUT api/<ValuesController>/5
        /// <summary>
        /// Cập nhật đơn hàng
        /// </summary>
        /// <param name="orderId">Id đơn hàng</param>
        /// <param name="updateOrderDto">Tham số cập nhật đơn hàng</param>
        /// <returns></returns>
        [HttpPut("{orderId}")]
        public async Task<OrderDto> Put(Guid orderId, [FromBody] UpdateOrderDto updateOrderDto)
        {
            return await _orderAppService.UpdateAsync(orderId, updateOrderDto);
        }

        // DELETE api/<ValuesController>/5
        /// <summary>
        /// API xóa đơn hàng
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpDelete("{orderId}")]
        public async Task<bool> Delete(Guid orderId)
        {
            return await _orderAppService.DeleteAsync(orderId);
        }
    }
}
