using AutoMapper;
using MISA.ProductManager.Entities;
using MISA.ProductManager.Products.Entities;

namespace MISA.ProductManager
{
    public class ProductManagerApplicationAutoMapperProfile : Profile
    {
        public ProductManagerApplicationAutoMapperProfile()
        {
            CreateMap<Product, ProductDto>(MemberList.Destination);
            CreateMap<ProductDto, Product>(MemberList.Source);
        }
    }
}