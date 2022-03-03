using AutoMapper;
using MISA.OrderManager.Entities;
using MISA.OrderManager.Orders.Entities;

namespace MISA.OrderManager
{
    public class OrderManagerApplicationAutoMapperProfile : Profile
    {
        public OrderManagerApplicationAutoMapperProfile()
        {
            CreateMap<Order, OrderDto>(MemberList.Destination).ForMember(d => d.OrderDetailDto, opt => opt.Ignore());

            CreateMap<OrderDto, Order>(MemberList.Source).ForSourceMember(s => s.OrderDetailDto, opt => opt.DoNotValidate());

            CreateMap<OrderDetail, OrderDetailDto>(MemberList.Destination);

            CreateMap<OrderDetailDto, OrderDetail>(MemberList.Source);
        }
    }
}