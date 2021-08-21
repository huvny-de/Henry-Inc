﻿using Henry_Inc.AdminApp.Services;
using Henry_Inc.Utilities.Constants;
using Henry_Inc.ViewModels.Catalogs.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Henry_Inc.AdminApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _configuration;

        public ProductController(IUserApiClient userApiClient,
            IConfiguration configuration,
            IProductApiClient productApiClient)
        {
            _productApiClient = productApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 3)
        {
            var languageId = HttpContext.Session.GetString(SystemConstant.AppSettings.DefaultLanguageId);
            var request = new GetManageProductPagingRequest()

            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                LanguageId = languageId
                
            };

            if (TempData != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }

            var data = await _productApiClient.GetPagings(request);
            ViewBag.Keyword = keyword;

            return View(data);
        }
    }
}