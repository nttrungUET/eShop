using Microsoft.AspNetCore.Mvc;
using MISA.ProductManager.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace MISA.ProductManager.Products
{
    [RemoteService]
    [Route("api/v1/products")]
    public class ProductsController : ProductManagerController
    {
        private readonly IProductAppService _productAppService;

        public ProductsController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        // GET: api/<ValuesController>
        /// <summary>
        /// API Lấy tất cả danh sách hóa đơn hiện có
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<ProductDto>> GetAll()
        {
            return await _productAppService.GetAllProductAsync();
        }

        // GET api/<ValuesController>/5
        /// <summary>
        /// API lấy hóa đơn theo ID
        /// </summary>
        /// <param name="productId">Id hóa đơn</param>
        /// <returns></returns>
        [HttpGet("{productId}")]
        public async Task<ProductDto> Get(Guid productId)
        {
            return await _productAppService.GetProductByIdAsync(productId);
        }

        // POST api/<ValuesController>
        /// <summary>
        /// Tạo mới hóa đơn mua hàng
        /// </summary>
        /// <param name="createOrderDto">Tham số tạo mới đơn hàng</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ProductDto> Post([FromBody] CreateProductDto createProductDto)
        {
            return await _productAppService.CreateAsync(createProductDto);
        }

        // PUT api/<ValuesController>/5
        /// <summary>
        /// Cập nhật đơn hàng
        /// </summary>
        /// <param name="orderId">Id đơn hàng</param>
        /// <param name="updateProductDto">Tham số cập nhật đơn hàng</param>
        /// <returns></returns>
        [HttpPut("{productId}")]
        public async Task<ProductDto> Put(Guid productId, [FromBody] UpdateProductDto updateProductDto)
        {
            return await _productAppService.UpdateAsync(productId, updateProductDto);
        }

        // DELETE api/<ValuesController>/5
        /// <summary>
        /// API xóa đơn hàng
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpDelete("{productId}")]
        public async Task<bool> Delete(Guid productId)
        {
            return await _productAppService.DeleteAsync(productId);
        }
    }
}
