using MISA.ProductManager.Entities;
using MISA.ProductManager.Products.Entities;
using MISA.ProductManager.PropductManager;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MISA.ProductManager.Products
{
    public class ProductAppService : ProductManagerAppService, IProductAppService
    {
        private readonly IProductRepository _productRepository;

        public ProductAppService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductDto> CreateAsync(CreateProductDto createProductDto)
        {
            try
            {
                var product = new Product()
                {
                    Price = createProductDto.Price,
                    ProductCode = createProductDto.ProductCode,
                    ProductName = createProductDto.ProductName,
                    Stock = createProductDto.Stock
                };

                var productInserted = await _productRepository.InsertAsync(product);

                return ObjectMapper.Map<Product, ProductDto>(productInserted);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return null;
            }
        }

        public async Task<bool> DeleteAsync(Guid productId)
        {
            try
            {
                var productDelete = new Product(productId);

                await _productRepository.DeleteAsync(productDelete);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return false;
            }
        }

        public async Task<List<ProductDto>> GetAllProductAsync()
        {
            var products = await _productRepository.GetListAsync();

            return ObjectMapper.Map<List<Product>, List<ProductDto>>(products);
        }

        public async Task<ProductDto> GetProductByIdAsync(Guid productId)
        {
            var product = await _productRepository.GetProductById(productId);

            return ObjectMapper.Map<Product, ProductDto>(product);
        }

        public async Task<ProductDto> UpdateAsync(Guid productId, UpdateProductDto updateProductDto)
        {
            try
            {
                var product = new Product(productId)
                {
                    Price = updateProductDto.Price,
                    ProductCode = updateProductDto.ProductCode,
                    ProductName = updateProductDto.ProductName,
                    Stock = updateProductDto.Stock
                };

                var productUpdated = await _productRepository.UpdateAsync(product);

                return ObjectMapper.Map<Product, ProductDto>(productUpdated);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return null;
            }
        }
    }
}
