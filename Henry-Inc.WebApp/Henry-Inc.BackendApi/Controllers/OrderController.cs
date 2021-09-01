using Henry_Inc.Application.Catalog.Products;
using Henry_Inc.ViewModels.Catalogs.Orders;
using Henry_Inc.ViewModels.Sales;
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
    public class OrderController : ControllerBase
    {
        private readonly IProductService _productService;

        public OrderController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost("{userName}")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create(string userName, [FromForm] CheckoutRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var orderId = await _productService.CreateOrder(userName, request);
            if (orderId == 0)
            {
                return BadRequest();
            }
            //var product = await _productService.GetById(orderId, request.LanguageId);
            return Ok();
        }
    }
}
