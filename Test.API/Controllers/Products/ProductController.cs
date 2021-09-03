using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Test.MODELS.Constants;
using Test.MODELS.Models;
using Test.SERVICES.Interfaces;

namespace Test.API.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Dependency
        private readonly IAddProductService _addProduct;
        private readonly IGetProductService _getProduct;
        private readonly IUpdateProductService _updateProduct;
        #endregion

        #region Constructor
        public ProductController(IAddProductService addProduct, IGetProductService getProduct, IUpdateProductService updateProduct)
        {
            _addProduct = addProduct;
            _getProduct = getProduct;
            _updateProduct = updateProduct;
        }
        #endregion

        #region Methods
        [HttpPost("AddProducts")]
        public async Task<IActionResult> Add(ProductModel product)
        {
            Response<object> resp = await _addProduct.Add(product);
            if (resp.Success) return StatusCode(201, resp);
            return StatusCode(400, resp);
        }

        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> Get()
        {
            Response<object> resp = await _getProduct.Get();
            if (resp.Success) return StatusCode(200, resp);
            return StatusCode(400, resp);
        }

        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> Update(ProductModel product)
        {
            Response<object> resp = await _updateProduct.Update(product);
            if (resp.Success) return StatusCode(201, resp);
            return StatusCode(400, resp);
        }
        #endregion
    }
}
