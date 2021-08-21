using Henry_Inc.Application.Commons;
using Henry_Inc.ViewModels.Catalogs.Products;
using Henry_Inc.ViewModels.Commons;
using Henry_Inc.ViewModels.System.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Henry_Inc.AdminApp.Services
{
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProductApiClient(IHttpClientFactory
            httpClientFactory, IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, configuration, httpContextAccessor)
        {
        }

        public async Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ProductViewModel>>(
                $"api/products/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&Keyword={request.Keyword}&languageId={request.LanguageId}");

            return data;
        }
    }
}