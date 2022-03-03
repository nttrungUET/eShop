using MISA.OrderManager.Entities;
using MISA.OrderManager.Enum;
using MISA.OrderManager.OrderManagers;
using MISA.OrderManager.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Uow;

namespace MISA.OrderManager.Orders
{
    public class OrderAppService : OrderManagerAppService, IOrderAppService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;

        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public OrderAppService(IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository, IUnitOfWorkManager unitOfWorkManager)
        {
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _unitOfWorkManager = unitOfWorkManager;
        }

        public async Task<OrderDto> CreateAsync(CreateOrderDto createOrderDto)
        {
            try
            {
                var order = new Order()
                {
                    CustomerName = createOrderDto.CustomerName,
                    OrderDate = DateTime.Now,
                    StateError = -1,
                    StateOrder = (int)StateOrderEnum.CreatedOrder
                };

                var orderDetail = new List<OrderDetail>();

                if (createOrderDto.CreateOrderDetailDto != null && createOrderDto.CreateOrderDetailDto.Count > 0)
                {
                    foreach(var orderDetailDto in createOrderDto.CreateOrderDetailDto)
                    {
                        orderDetail.Add(new OrderDetail()
                        {
                            OrderId = order.Id,
                            ProductId = orderDetailDto.ProductId,
                            Quantity = orderDetailDto.Quantity
                        });
                    }
                }

                Order orderInserted;
                using (var uow = _unitOfWorkManager.Begin(requiresNew: true, isTransactional: false))
                {
                    orderInserted = await _orderRepository.InsertAsync(order);
                    await _orderDetailRepository.InsertManyAsync(orderDetail);

                    if (orderInserted != null)
                        await uow.CompleteAsync();
                }

                if (orderInserted == null)
                    return null;

                var orderDto = ObjectMapper.Map<Order, OrderDto>(orderInserted);
                orderDto.OrderDetailDto = ObjectMapper.Map<List<OrderDetail>, List<OrderDetailDto>>(orderDetail);
                
                return orderDto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return null;
            }
        }

        public Task<bool> DeleteAsync(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderDto>> GetAllOrderAsync()
        {
            var orders = await _orderRepository.GetListAsync();

            return ObjectMapper.Map<List<Order>, List<OrderDto>>(orders);
        }

        public async Task<OrderDto> GetOrderByIdAsync(Guid orderId)
        {
            var order = await _orderRepository.GetOrderById(orderId);

            return ObjectMapper.Map<Order, OrderDto>(order);
        }

        public async Task<OrderDto> UpdateAsync(Guid orderId, UpdateOrderDto updateOrderDto)
        {
            try
            {
                var order = new Order(orderId)
                {
                    CustomerName = updateOrderDto.CustomerName,
                    OrderDate = updateOrderDto.OrderDate,
                    StateError = updateOrderDto.StateError,
                    StateOrder = updateOrderDto.StateOrder
                };

                var orderDetail = new List<OrderDetail>();

                if (updateOrderDto.OrderDetailDto != null && updateOrderDto.OrderDetailDto.Count > 0)
                {
                    foreach (var orderDetailDto in updateOrderDto.OrderDetailDto)
                    {
                        orderDetail.Add(new OrderDetail()
                        {
                            OrderId = order.Id,
                            ProductId = orderDetailDto.ProductId,
                            Quantity = orderDetailDto.Quantity
                        });
                    }
                }

                Order orderUpdated;
                using (var uow = _unitOfWorkManager.Begin(requiresNew: true, isTransactional: false))
                {
                    orderUpdated = await _orderRepository.UpdateAsync(order);
                    
                    if (updateOrderDto.OrderDetailDto != null && updateOrderDto.OrderDetailDto.Count > 0)
                        await _orderDetailRepository.InsertManyAsync(orderDetail);

                    if (orderUpdated != null)
                        await uow.CompleteAsync();
                }

                if (orderUpdated == null)
                    return null;

                var orderAfterUpdated = ObjectMapper.Map<Order, OrderDto>(orderUpdated);
                orderAfterUpdated.OrderDetailDto = ObjectMapper.Map<List<OrderDetail>, List<OrderDetailDto>>(orderDetail);

                return orderAfterUpdated;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return null;
            }
        }
    }
}
