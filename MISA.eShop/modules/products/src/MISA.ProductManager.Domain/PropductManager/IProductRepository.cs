using MISA.ProductManager.Entities;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace MISA.ProductManager.PropductManager
{
    public interface IProductRepository : IBasicRepository<Product>
    {
        Task<Product> GetProductById(Guid productId);
    }
}
