using Henry_Inc.Application.Catalog.Products;
using Henry_Inc.ViewModels.Catalogs.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Henry_Inc.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _pubicProductService;
        private readonly IManageProductService _manageProductService;

        public ProductController(IPublicProductService pubicProductService, IManageProductService manageProductService)
        {
            _pubicProductService = pubicProductService;
            _manageProductService = manageProductService;
        }
        // http://localhost:port/product
        [HttpGet("{languageId}")]
        public async Task<IActionResult> Get(string languageId)
        {
            var products = await _pubicProductService.GetAll(languageId);
            return Ok(products);
        }
        // http://localhost:port/product/public-paging

        [HttpGet("public-paging/{languageId}")]
        public async Task<IActionResult> Get([FromQuery] GetPublicProductPagingRequest request)
        {
            var products = await _pubicProductService.GetAllByCategoryId(request);
            return Ok(products);
        }
        // http://localhost:port/product/id
        [HttpGet("{id}/{languageId}")]
        public async Task<IActionResult> GetById(int id, string languageId)
        {
            var products = await _manageProductService.GetById(id, languageId);
            if (products == null)
            {
                return BadRequest("Cannot find product");
            }
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            var productId = await _manageProductService.Create(request);
            if (productId == 0)
            {
                return BadRequest();
            }
            var product = await _manageProductService.GetById(productId, request.LanguageId);
            return CreatedAtAction(nameof(GetById), new { id = product }, product);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            var affectedResult = await _manageProductService.Update(request);
            if (affectedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
        [HttpPut("price/{id}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice( int id, decimal newPrice)
        {
            var isSuccessful = await _manageProductService.UpdatePrice(id, newPrice);
            if (isSuccessful)
            {
                return Ok();
            }
            return BadRequest();

        }
        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedResult = await _manageProductService.Delete(productId);
            if (affectedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
