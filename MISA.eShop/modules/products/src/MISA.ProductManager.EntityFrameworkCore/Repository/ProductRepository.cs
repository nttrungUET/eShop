using Microsoft.EntityFrameworkCore;
using MISA.ProductManager.Entities;
using MISA.ProductManager.EntityFrameworkCore;
using MISA.ProductManager.PropductManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MISA.ProductManager.Repository
{
    public class ProductRepository : EfCoreRepository<ProductManagerDbContext, Product>, IProductRepository
    {
        public ProductRepository(IDbContextProvider<ProductManagerDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Product> GetProductById(Guid productId)
        {
            var db = await GetDbContextAsync();

            var product = db.Products
                            .AsNoTracking().Where(e => e.Id == productId).ToList().FirstOrDefault();

            return product;
        }
    }
}
